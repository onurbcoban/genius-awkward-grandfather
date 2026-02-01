using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance;

    [Header("Ayarlar")]
    public CanvasGroup blackScreenCanvasGroup;
    
    // Varsayılan değerler
    public float defaultTransitionTime = 1f;
    public float defaultWaitTime = 1f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // --- ÖNEMLİ KISIM ---
    // Bu fonksiyonun parantez içi (parametreleri) Ending scriptinle uyumlu olmalı.
    // Artık 3 veri kabul ediyor: İsim, Geçiş Süresi, Bekleme Süresi.
    public void LoadLevel(string sceneName, float customTransitionTime = -1f, float customWaitTime = -1f)
    {
        StartCoroutine(TransitionCo(sceneName, customTransitionTime, customWaitTime));
    }

    IEnumerator TransitionCo(string sceneName, float timeOverride, float waitOverride)
    {
        // Eğer -1 gönderildiyse (boş bırakıldıysa) varsayılanı kullan, yoksa özel süreyi kullan
        float duration = (timeOverride < 0) ? defaultTransitionTime : timeOverride;
        float wait = (waitOverride < 0) ? defaultWaitTime : waitOverride;

        // 1. Kararma
        blackScreenCanvasGroup.blocksRaycasts = true;
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / duration;
            blackScreenCanvasGroup.alpha = t;
            yield return null;
        }

        // 2. Bekleme
        yield return new WaitForSeconds(wait);

        // 3. Yükleme
        SceneManager.LoadScene(sceneName);
        yield return null;

        // 4. Açılma
        t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / duration;
            blackScreenCanvasGroup.alpha = 1f - t;
            yield return null;
        }

        blackScreenCanvasGroup.blocksRaycasts = false;
    }
}
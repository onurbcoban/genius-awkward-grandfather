using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    public static LevelLoader Instance;

    [Header("Varsayılan Ayarlar")]
    public CanvasGroup blackScreenCanvasGroup;
    public float defaultTransitionTime = 1f; // Varsayılan geçiş hızı
    public float defaultWaitTime = 1f;       // Varsayılan bekleme süresi

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

    // GÜNCELLENEN KISIM: Opsiyonel Parametreler
    // Eğer sadece sahne adı girilirse, süreler -1 olur ve varsayılan kullanılır.
    // Eğer sahne adı + süre girilirse, o süreler kullanılır.
    public void LoadLevel(string sceneName, float customTransitionTime = -1f, float customWaitTime = -1f)
    {
        StartCoroutine(TransitionCo(sceneName, customTransitionTime, customWaitTime));
    }

    IEnumerator TransitionCo(string sceneName, float timeOverride, float waitOverride)
    {
        // Hangi süreyi kullanacağına karar ver
        // Eğer -1 geldiyse (yani boş bırakıldıysa) varsayılanı (default) kullan, yoksa gönderileni kullan.
        float duration = (timeOverride < 0) ? defaultTransitionTime : timeOverride;
        float wait = (waitOverride < 0) ? defaultWaitTime : waitOverride;

        // 1. AŞAMA: KARARMA
        blackScreenCanvasGroup.blocksRaycasts = true;
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime / duration;
            blackScreenCanvasGroup.alpha = t;
            yield return null;
        }

        // 2. AŞAMA: BEKLEME (Senin belirlediğin özel süre kadar)
        yield return new WaitForSeconds(wait);

        // 3. AŞAMA: YÜKLEME
        SceneManager.LoadScene(sceneName);
        yield return null;

        // 4. AŞAMA: AÇILMA
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
using System.Collections;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject letterUpLeft, letterMiddleRight, letterDownLeft, letterDownRight;
    public GameObject realLetterUpLeft, realLetterMiddleRight, realLetterDownLeft, realLetterDownRight;
    public GameObject maskingTaped, template, fakes, lastTalks;
    public GameObject blockerPanel;
    private bool isGameEnded = false;
    public AudioSource maskingTape;

    private float distanceLimit = 2f; 

    void Update()
    {
        if (isGameEnded) return;

        int currentFrameCorrectCount = 0;

        if (Vector2.Distance(realLetterUpLeft.transform.position, letterUpLeft.transform.position) < distanceLimit)
        {
            currentFrameCorrectCount++;

        }

        if (Vector2.Distance(realLetterMiddleRight.transform.position, letterMiddleRight.transform.position) < distanceLimit)
        {
            currentFrameCorrectCount++;
        }

        if (Vector2.Distance(realLetterDownLeft.transform.position, letterDownLeft.transform.position) < distanceLimit)
        {
            currentFrameCorrectCount++;
        }

        if (Vector2.Distance(realLetterDownRight.transform.position, letterDownRight.transform.position) < distanceLimit)
        {
            currentFrameCorrectCount++;
        }

        if (currentFrameCorrectCount == 4)
        {
            Debug.Log("YOU WON! TEBRİKLER!");
            
            isGameEnded = true;
            
            // Sahne geçişi sürecini başlat
            StartCoroutine(WinAndLoadScene());
        }
    }

    IEnumerator WinAndLoadScene()
    {
        // 1. TIKLAMAYI ENGELLE (Bloker Paneli Aç)
        // Oyuncu artık parçaları hareket ettiremesin.
        if(blockerPanel != null) 
            blockerPanel.SetActive(true);

        // 2. BEKLE (Zafer Anı)
        // Son parçayı koyduktan sonra 1 saniye o halini görsün.
        // Not: Time.timeScale kullanmıyoruz, çünkü animasyonun çalışması lazım.
        yield return new WaitForSeconds(1f);

        // 3. SAHNEYİ YÜKLE (Crossfade ile)
        // LevelLoader scriptini çağırıyoruz.
        // İstersen özel süreler de verebilirsin: LoadLevel(nextSceneName, 1f, 0.5f);
        if (LevelLoader.Instance != null)
        {
            LevelLoader.Instance.LoadLevel("Ending", 1, 4);
             maskingTape.Play();
        }
        else
        {
            // Eğer sahnede LevelLoader yoksa (unutulmuşsa) direkt yükle (Yedek plan)
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        LevelLoader.Instance.LoadLevel("Cover", 1 , 0);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}

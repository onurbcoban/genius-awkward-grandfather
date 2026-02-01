using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Letter : MonoBehaviour,IPointerClickHandler
{
    public AudioSource paperSlide;
    public void OnPointerClick(PointerEventData eventData)
    {
        LevelLoader.Instance.LoadLevel("Table");
        paperSlide.Play();
    }
}

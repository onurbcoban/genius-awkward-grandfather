using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Cover : MonoBehaviour, IPointerClickHandler
{
    public AudioSource coverOpen;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick");
        LevelLoader.Instance.LoadLevel("Letter" , 2, 2);
        coverOpen.Play();
    }
}

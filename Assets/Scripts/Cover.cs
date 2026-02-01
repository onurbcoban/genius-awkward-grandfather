using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Cover : MonoBehaviour, IPointerClickHandler
{
    public AudioSource coverOpen;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick");
        SceneManager.LoadScene("Letter");
        coverOpen.Play();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Letter : MonoBehaviour,IPointerClickHandler
{
    public AudioSource paperSlide;
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("Table");
        paperSlide.Play();
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

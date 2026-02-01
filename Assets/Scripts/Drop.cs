using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public int id;
    public static Vector3 originalScale;
    public AudioSource soundPlacing;

    void Awake()
    {
        
    }
    public void Scale()
    {
    }
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null )
        {
        soundPlacing.Play();

            /*    if(eventData.pointerDrag.GetComponent<DragPiece>().id == id)
            {
                Debug.Log("true");
            }
                else
            {
                Debug.Log("false");
            }*/
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                this.GetComponent<RectTransform>().anchoredPosition;
                //eventData.pointerDrag.GetComponent<RectTransform>().localScale *= 2;
                eventData.pointerDrag.GetComponent<RectTransform>().localScale = new Vector3(2f,2f,2f);
    }
    }
    /*public void ChangeScale()
    {
        if(multiplyScale)
        this.transform.localScale = originalScale * 2;
        else
        this.transform.localScale = originalScale;
    }*/

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

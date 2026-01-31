using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public int id;
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null )
        {
                if(eventData.pointerDrag.GetComponent<DragPiece>().id == id)
            {
                Debug.Log("true");
            }
                else
            {
                Debug.Log("false");
            }
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                this.GetComponent<RectTransform>().anchoredPosition;
        }        
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

using UnityEngine;
using UnityEngine.EventSystems;
public class DragPiece : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    private RectTransform rectTrans;
    public Canvas myCanvas;
    public CanvasGroup canvasGroup;
    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData click)
    {
        Debug.Log("Click");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.blocksRaycasts = false;
        transform.localScale = Vector3.one;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTrans.anchoredPosition += eventData.delta /myCanvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;

    }

} 

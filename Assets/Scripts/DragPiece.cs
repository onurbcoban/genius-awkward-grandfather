using UnityEngine;
using UnityEngine.EventSystems;
public class DragPiece : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    
    /*Camera cam;
    Vector3 offset, targetPosition;
    private bool isMouseDragged = false;
    private bool isInsideTarget = false;
    //public GameObject leftDownTemplate, paperLeftDownFake1;*/
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private RectTransform rectTrans;
    public Canvas myCanvas;
    public CanvasGroup canvasGroup;
    public GameObject realLetterUpLeftZoomed, realLetterUpRightZoomed, realLetterMiddleLeftZoomed, realLetterMiddleRightZoomed,
    realLetterDownLeftZoomed, realLetterDownRightZoomed;
    public GameObject fake1LetterUpLeftZoomed, fake1LetterUpRightZoomed, fake1LetterMiddleLeftZoomed, fake1LetterMiddleRightZoomed,
    fake1LetterDownLeftZoomed, fake1LetterDownRightZoomed;
    public int id;
    public GameObject fake2LetterUpLeftZoomed, fake2LetterUpRightZoomed, fake2LetterMiddleLeftZoomed, fake2LetterMiddleRightZoomed,
    fake2LetterDownLeftZoomed, fake2LetterDownRightZoomed;

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
        if(Input.GetKeyDown(KeyCode.LeftAlt))
        {
            
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.blocksRaycasts = false;
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
    /*void OnMouseDown() {
offset = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
Debug.Log("OnMouseDown");
}

void OnMouseDrag() 
{
Vector3 newPosition = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
isMouseDragged = true;

//Debug.Log("OnMouseDrag");

}
void OnMouseUpAsButton()
{
isMouseDragged = false;
if(isInsideTarget && !isMouseDragged)
{
transform.position = targetPosition;
}
isInsideTarget = false;
}

void OnMouseOver()
{
}*/

    /*void OnCollisionEnter2D(Collision2D other)

    {
        if(other.gameObject.CompareTag("LeftDownTemplate"))
        {
            isInsideTarget = true;
            targetPosition = leftDownTemplate.transform.position; 
            Debug.Log("OnCollisions");

        }
        //else if(gameObject.CompareTag("LeftDownFake1") && !other.CompareTag("LeftDownTemplate"))
        //{
        //    isInsideTarget = false;
        //}
    }*/



    //Tutmayı bıraktığında o alanın içindeyse o alana ortalanmış şekilde oturacak
    // 
} 

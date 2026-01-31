using UnityEngine;

public class DragPiece : MonoBehaviour
{
    Camera cam;
    Vector3 offset, targetPosition;
    private bool isMouseDragged = false;
    private bool isInsideTarget = false;
    public GameObject leftDownTemplate, paperLeftDownFake1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
            offset = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("OnMouseDown");
        }

    void OnMouseDrag() 
        {
            Vector3 newPosition = cam.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
            isMouseDragged = true;
            
            Debug.Log("OnMouseDrag");

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
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        if(gameObject.CompareTag("LeftDownFake1") && other.CompareTag("LeftDownTemplate") //&& !isMouseDragged)
        )
        {
            isInsideTarget = true;
            targetPosition = leftDownTemplate.transform.position; 

        }
    }

    //Tutmayı bıraktığında o alanın içindeyse o alana ortalanmış şekilde oturacak
    // 
} 

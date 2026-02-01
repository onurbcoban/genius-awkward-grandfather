using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    public int id;
    public static Vector3 originalScale;
    public AudioSource soundPlacing;
    

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null )
        {
        soundPlacing.Play();
                eventData.pointerDrag.transform.position = transform.position;
                //eventData.pointerDrag.GetComponent<RectTransform>().localScale *= 2;
                eventData.pointerDrag.GetComponent<RectTransform>().localScale = new Vector3(2f,2f,2f);
        }
        
    }
}

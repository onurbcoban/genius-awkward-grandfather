using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class HoverItem : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    void Start()
    {
        myImage = GetComponent<Image>();
    }
    private Image myImage;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(PreviewManager.Instance != null)
        {
            PreviewManager.Instance.SetCurrentHover(myImage.sprite);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(PreviewManager.Instance != null)
        {
            PreviewManager.Instance.ClearCurrentHover();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        
    }
}

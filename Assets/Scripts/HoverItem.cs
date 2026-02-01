using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


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
}

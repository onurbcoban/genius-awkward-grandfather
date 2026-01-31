using UnityEngine;
using UnityEngine.UI;
public class PreviewManager : MonoBehaviour
{
    public static PreviewManager Instance;

    public CanvasGroup previewCanvasGroup;
    public Image PreviewImage;
    private Sprite currentHoveredSprite;
    private void Awake()
    {
        if(Instance == null) Instance = this;
        else Destroy(gameObject);

        HidePreview();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHoveredSprite != null && Input.GetKey(KeyCode.LeftAlt))
        {
            ShowPreview();
        }
        else
        {
            HidePreview();
        }

    }
    public void SetCurrentHover(Sprite sprite)
    {
        currentHoveredSprite = sprite;
        PreviewImage.sprite = sprite;
    }
    public void ClearCurrentHover()
    {
        currentHoveredSprite = null;
    }

    private void ShowPreview()
    {
        previewCanvasGroup.alpha = 1;
    }
    private void HidePreview()
    {
        previewCanvasGroup.alpha = 0;
    }
}

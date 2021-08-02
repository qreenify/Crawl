using System;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Card : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Image art;
    [SerializeField] private Text rageCost;
    [SerializeField] private Text cardName;
    [SerializeField] private Text description;
    public CardInfo cardInfo;
    
    RectTransform rectTransform;
    Canvas canvas;
    CanvasGroup canvasGroup;
    private Vector2 position;
    
    public Action OnCardDrawn;
    public Action OnCardPlayed;
    public Action OnCardDiscarded;
    public Action OnCardExhausted;
    void Start()
    {
        rageCost.text = cardInfo.rageCost.ToString();
        cardName.text = cardInfo.name;
        gameObject.name = cardInfo.name;
        art.sprite = cardInfo.image;
        description.text = cardInfo.description;
        rectTransform = GetComponent<RectTransform>();
        canvas = FindObjectOfType<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Name: " +cardName);
        sb.Append("Cost: " +cardInfo.rageCost);
        return sb.ToString();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log($"{cardName} has been clicked on");
        position = rectTransform.position;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging Started");
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.5f;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log($"{cardName} is being dragged");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        rectTransform.position = position;
    }
}
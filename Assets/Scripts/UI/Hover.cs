using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform buttonRectTransform;
    private Vector3 originalScale;

    private void Start()
    {
        buttonRectTransform = GetComponent<RectTransform>();
        originalScale = buttonRectTransform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonRectTransform.localScale = originalScale * 1.15f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonRectTransform.localScale = originalScale;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    Transform canvaT;
    private void Awake() {
        canvaT = GameObject.FindGameObjectWithTag("Canvas").transform;
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop"); 
        if (eventData.pointerDrag != null){
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Debug.Log("Soltado en un slot "+ GetComponent<RectTransform>().anchoredPosition);
        }
    }
}

using UnityEngine;
using UnityEngine.EventSystems;

public class LongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool isDown;

    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
    }

    
}


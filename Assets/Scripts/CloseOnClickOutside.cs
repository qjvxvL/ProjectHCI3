using UnityEngine;
using UnityEngine.EventSystems;

public class CloseOnClickOutside : MonoBehaviour, IPointerClickHandler
{
    public GameObject card;  // Reference to the card you want to close

    public void OnPointerClick(PointerEventData eventData)
    {
        if (card.activeSelf)
        {
            // Hide the card
            card.SetActive(false);
            // Optionally, hide the blocking panel too
            gameObject.SetActive(false);
        }
    }
}

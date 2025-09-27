using System.Collections;
using UnityEngine;

public class ClickThatDotToHide : MonoBehaviour
{
    public GameObject dot;
    public GameObject button;
    public float toggleDelay;
    public bool isActive;

    void Start()
    {
        // Initialize isActive based on dot's initial active state
        
        // Set the initial state of button to be opposite of dot
       
    }

    void Update()
    {
        isActive = dot.activeSelf;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider == GetComponent<Collider>())
                {
                    StartCoroutine(ClickToHide(!isActive));
                }
            }
        }
    }

    IEnumerator ClickToHide(bool state)
    {
        yield return new WaitForSeconds(toggleDelay);
        dot.SetActive(state);
        button.SetActive(!state);
        isActive = state;
    }
}

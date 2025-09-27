using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class TouchToInteract : MonoBehaviour
{
    public GameObject myObject;
    public Collider myCollider;
    public bool isActive;
    public float toggleDelay = 0.1f;

     public UnityEngine.UI.Image headDisease;

     void Start()
    {
        // Assign the collider component to myCollider
        myCollider = myObject.GetComponent<Collider>();

        if (myCollider == null)
        {
            Debug.LogError("Collider component not found on myObject!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if there is at least one touch and if myCollider is not null
        if (Input.GetMouseButtonDown(0) && myCollider != null)
        {
            // Raycast to detect if the touch is hitting myObject
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.collider == myCollider)
                {
                    Debug.Log("Hit object: " + hit.collider.gameObject.name);
                    Debug.Log("Hit point: " + hit.point);
                    if (!isActive) {
                        StartCoroutine(ToggleDiseaseImage(true));
                    }
                    else if (isActive) {
                       StartCoroutine(ToggleDiseaseImage(false));
                    }
                }       
            }
        }
    }

    IEnumerator ToggleDiseaseImage(bool state)
    {
        yield return new WaitForSeconds(toggleDelay);
        headDisease.gameObject.SetActive(state);
        isActive = state;
    }
}


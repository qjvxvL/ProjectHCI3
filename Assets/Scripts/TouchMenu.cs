using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMenu : MonoBehaviour
{
    public bool isActive;
    public GameObject toDiseaseDesc;
    public float toggleDelay = 0.1f;
    // Start is called before the first frame update
    void Update()
    {
        isActive = toDiseaseDesc.activeSelf;
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider == this.GetComponent<Collider>())
                {        
                    if (!isActive) {
                        StartCoroutine(ToggleDiseaseDesc(true));
                    }
                    else if (isActive) {
                       StartCoroutine(ToggleDiseaseDesc(false));
                    }
                }
            }
        }
    }

    IEnumerator ToggleDiseaseDesc(bool state)
    {
        yield return new WaitForSeconds(toggleDelay);
        toDiseaseDesc.gameObject.SetActive(state);
        isActive = state;
    }
}

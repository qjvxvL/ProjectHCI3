using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfficientClickScript : MonoBehaviour
{
    public bool isGameObjectActive;
    public bool isActive;
    public GameObject specificPartMenu;
    public GameObject dot;
    public float toggleDelay = 0.1f;
    public GameObject button;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
                    StartCoroutine(ClickToOpen(!isActive));
                }
            }
        }
        
    }

    IEnumerator ClickToOpen(bool state) {
         yield return new WaitForSeconds(toggleDelay);
        dot.SetActive(state);
        button.SetActive(!state);
        isActive = state;
    }

    public void SpecificBodyTouched() {
        Debug.Log("chickenLeftEyeTouched");
        if(!isGameObjectActive) {
            StartCoroutine(ToggleMenu(true));
            dot.SetActive(false);
        } 
    }

    public void BackFromDesc() {
        Debug.Log("chickenEyesTouchedBack");
        StartCoroutine(ToggleDiseaseImage(false));
    }

    IEnumerator ToggleDiseaseImage(bool state)
    {
        yield return new WaitForSeconds(toggleDelay);
        button.gameObject.SetActive(state);
        isActive = state;
    }

    IEnumerator ToggleMenu(bool state) {
        yield return new WaitForSeconds(toggleDelay);
        specificPartMenu.gameObject.SetActive(state);
        isActive = state;
    }


}

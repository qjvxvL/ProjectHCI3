using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractClick : MonoBehaviour
{
    public float toggleDelay = 0.1f;
    public bool isActive;
    public bool isActiveCoryza;
    public bool isActiveCoryzaMenu;
    public UnityEngine.UI.RawImage darkening;
    public UnityEngine.UI.RawImage darkeningCoryza;
    public UnityEngine.UI.Image coryzaMenu;
    public GameObject dot;
    public bool isActiveCoryzaMenu2;
    public UnityEngine.UI.RawImage darkening2;
    public UnityEngine.UI.RawImage darkeningCoryza2;
    public UnityEngine.UI.Image coryzaMenu2;
    public GameObject dot2;
    
    public Collider myCollider;
    // Start is called before the first frame update
    void Start()
    {
        isActiveCoryza = dot.activeSelf;
    }


    // public void ChickenHeadTouch() {
    //     Debug.Log("ChickenHeadTouch");
    //      if (!isActive) {
    //         StartCoroutine(ToggleDiseaseImage(true));
    //     }
    //     else if (isActive) {
    //         StartCoroutine(ToggleDiseaseImage(false));
    //     }
        
    // }

    // public void chickenHeadTouchBack() {
    //     Debug.Log("chickenHeadTouchBack");
    //     StartCoroutine(ToggleDiseaseImage(false));
    // }

// Left Eye
    public void chickenLeftEyeTouched() {
        Debug.Log("chickenLeftEyeTouched");
        if(!isActiveCoryzaMenu) {
            StartCoroutine(ToggleCoryzaMenuDiseaseImage(true));
            dot.SetActive(false);
        } 
    }

    // public void afterLeftEyeTouched() {
    //     if (!isActiveCoryzaMenu) {
    //         StartCoroutine(ToggleCoryzaDiseaseImage(true));
    //     }
    // }

    // public void afterLeftEyeTouchedBack() {
    //     StartCoroutine(ToggleCoryzaDiseaseImage(false));
    // }
   

// Right Eye
    public void chickenRightEyeTouched() {
        Debug.Log("chickenRightEyeTouched");
        if(!isActiveCoryzaMenu2) {
            StartCoroutine(ToggleCoryzaMenuDiseaseImage2(true));
            dot2.SetActive(false);
        }
    }

    

    
    // all eyes
    public void chickenEyesTouchedBack() {
        Debug.Log("chickenEyesTouchedBack");
        StartCoroutine(ToggleCoryzaDiseaseImage(false));
    }

    // IEnumerator ToggleDiseaseImage(bool state)
    // {
    //     yield return new WaitForSeconds(toggleDelay);
    //     darkening.gameObject.SetActive(state);
    //     isActive = state;
    // }

    IEnumerator ToggleCoryzaMenuDiseaseImage(bool state) {
        yield return new WaitForSeconds(toggleDelay);
        coryzaMenu.gameObject.SetActive(state);
        isActiveCoryza = state;
    }

    IEnumerator ToggleCoryzaMenuDiseaseImage2(bool state) {
        yield return new WaitForSeconds(toggleDelay);
        coryzaMenu2.gameObject.SetActive(state);
        isActiveCoryza = state;
    }

    IEnumerator ToggleCoryzaDiseaseImage(bool state)
    {
        yield return new WaitForSeconds(toggleDelay);
        darkeningCoryza.gameObject.SetActive(state);
        isActive = state;
    }

    // void Update() {
    //     if (Input.GetMouseButtonDown(0) && myCollider != null)
    //     {
    //         // Raycast to detect if the touch is hitting myObject
    //         RaycastHit hit;
    //         if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
    //         {
    //             if (hit.collider == myCollider)
    //             {
    //                 Debug.Log("Hit object: " + hit.collider.gameObject.name);
    //                 Debug.Log("Hit point: " + hit.point);
    //                 if (!isActive) {
    //                     StartCoroutine(ToggleDiseaseImage(true));
    //                 }
    //                 else if (isActive) {
    //                    StartCoroutine(ToggleDiseaseImage(false));
    //                 }
    //             }       
    //         }
    //     }
    // }
    
}

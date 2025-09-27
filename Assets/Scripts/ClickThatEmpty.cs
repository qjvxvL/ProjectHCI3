using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickThatEmpty : MonoBehaviour
{
    public bool isActive;
    public float toggleDelay = 0.1f;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

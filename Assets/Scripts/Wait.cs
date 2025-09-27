using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public float waitTime = 2;
   
    void Start()
    {
        StartCoroutine(WaitIntro());     
    }

    IEnumerator WaitIntro() {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageMyScene : MonoBehaviour
{
   public void ToOnboard2Start () {
        SceneManager.LoadScene("Onboard2");
    }

    public void ToOnboard3 () {
        SceneManager.LoadScene("Onboard3");
    }

    public void ToMainMenu () {
        SceneManager.LoadScene("MainMenu");
    }
    public void ToHistory () {
        SceneManager.LoadScene("History");
    }
    public void ToSettings () {
        SceneManager.LoadScene("Settings");
    }
    public void ToProfile() {
        SceneManager.LoadScene("Profile");
    }
    public void ToChickenMenu () {
        SceneManager.LoadScene("ChickenAR");
    }
    public void ToCowPreview () {
        SceneManager.LoadScene("CowPreview");
    }
    public void ToCowAR () {
        SceneManager.LoadScene("CowAR");
    }
      public void ToGoatPreview () {
        SceneManager.LoadScene("GoatPreview");
    }
    public void ToGoatAR () {
        SceneManager.LoadScene("GoatAR");
    }
      public void ToDuckPreview () {
        SceneManager.LoadScene("DuckPreview");
    }
    public void ToDuckAR () {
        SceneManager.LoadScene("DuckAR");
    }
    public void ChickenPreview () {
        SceneManager.LoadScene("ChickenPreview");
    }
}



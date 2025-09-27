using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickBlockingPanel : MonoBehaviour
{
    public GameObject panel;

    void Start()
    {
        // Initially hide the panel
        panel.SetActive(false);
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }
}

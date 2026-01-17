using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _panelMain;
    [SerializeField]
    private GameObject _panelSettings;
    [SerializeField]
    private GameObject _panelChoose;
    private void Start()
    {
        openMain();   
    }

    public void openMain()  
    {
        _panelMain.SetActive(true);
        _panelSettings.SetActive(false);
        _panelChoose.SetActive(false);
    }

    public void openSettings() 
    {
        _panelMain.SetActive(false);
        _panelSettings.SetActive(true);
        _panelChoose.SetActive(false);
    }
    public void openChoose()
    {
        _panelMain.SetActive(false);
        _panelSettings.SetActive(false);
        _panelChoose.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }


}

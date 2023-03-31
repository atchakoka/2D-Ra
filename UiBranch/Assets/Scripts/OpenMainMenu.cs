using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMainMenu : MonoBehaviour
{
    [SerializeField] public GameObject uiMenu;
    public bool MainMenuSwitch=false;

    // Start is called before the first frame update
    void Start()
    {
        uiMenu.SetActive(MainMenuSwitch);
        MainMenuSwitch=true;
    }

    void MainMenuSwitcher()
    {
        MethodFromOpenMainMenu();
        // uiMenu.SetActive(MainMenuSwitch);
        // if(MainMenuSwitch==true) {MainMenuSwitch=false;}
        // else {MainMenuSwitch=true;}
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenuSwitcher();
        }
    }

    public void MethodFromOpenMainMenu()
    {
        uiMenu.SetActive(MainMenuSwitch);
        if(MainMenuSwitch==true) {MainMenuSwitch=false;}
        else {MainMenuSwitch=true;}
        Debug.Log("Debug from OpenMenu");
    }
}

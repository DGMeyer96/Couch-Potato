using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject StartMenu;

    

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        StartMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Start_Button()
    {
        MainMenu.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void Options_Button()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void Quit_Button()
    {
        Application.Quit();
    }

    public void Back_Button(string CurrentMenu)
    {
        if(CurrentMenu == "Start")
        {
            StartMenu.SetActive(false);
            MainMenu.SetActive(true);
        }
        else if(CurrentMenu == "Options")
        {
            OptionsMenu.SetActive(false);
            MainMenu.SetActive(true);
        }
        else
        {
            Debug.LogError("The prefab name for the back button is invalid");
        }
    }
}

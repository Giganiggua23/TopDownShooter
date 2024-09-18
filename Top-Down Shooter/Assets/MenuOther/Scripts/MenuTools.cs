using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTools : MonoBehaviour
{
    /* 
       Menu 0 Game 1
     
    */

    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Settings;

    void Start()
    {
        Menu.SetActive(true);
        Settings.SetActive(false);
    }


    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Settingsfalse ()
    {
        Menu.SetActive(true);
        Settings.SetActive(false);
    }
    public void Settingstrue()
    {
        Menu.SetActive(false);
        Settings.SetActive(true);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    
}

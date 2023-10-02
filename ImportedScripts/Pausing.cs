using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Pausing: MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject ThePlayer;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                

            
            
            if (GameIsPaused == true)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

            }
            else 
            {
                
                Paused();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

            }
        }
    }

    
    public void Resume()
    {

        Time.timeScale = 1;
        GameIsPaused = false;
        PauseMenuUI.SetActive(false);
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;

    }

    void Paused()
    {
        Time.timeScale = 0;
        GameIsPaused = true;
        PauseMenuUI.SetActive(true);
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}

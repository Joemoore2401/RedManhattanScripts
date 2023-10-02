using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerStopMovement : MonoBehaviour
{

    public GameObject fps;
    public bool MouseOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MouseOn == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
    }
   
    public void StopPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = false;
        MouseOn = true;
    }
    
    public void StartPlayer()
    {
        fps.GetComponent<FirstPersonController>().enabled = true;
        MouseOn = false;
    }
}

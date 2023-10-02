using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorActive : MonoBehaviour
{

    public static bool On;


    void Start()
    {
        On = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(On == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }
}

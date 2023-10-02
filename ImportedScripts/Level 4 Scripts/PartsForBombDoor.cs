using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsForBombDoor : MonoBehaviour
{

    public bool Bomb1 = false;
    public bool Bomb2 = false;
    public GameObject TableOn;
    public GameObject TableOff;






    private void Update()
    {


        if (Bomb1 == true)
        {
            if (Bomb2 == true)
            {
                TableOn.SetActive(true);
                TableOff.SetActive(false);
            }
        }






    }
}

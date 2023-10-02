using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingAcidBomb : MonoBehaviour
{

    public bool Bomb1 = false;
    public bool Bomb2 = false;
    public bool Bomb3 = false;
    public GameObject trigger;
   


   


    private void Update()
    {
  
            
                if (Bomb1 == true)
                {
                    if (Bomb2 == true)
                    {
                        if (Bomb3 == true)
                        {
                           trigger.SetActive(true);
                           
                        }
                    }
                }

            
        



    }
}

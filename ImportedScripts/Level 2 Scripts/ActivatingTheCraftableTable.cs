using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingTheCraftableTable : MonoBehaviour
{
    public bool Bomb1 = false;
    public bool Bomb2 = false;
    public bool Bomb3 = false;
    public GameObject CraftableTableOn;
    public GameObject TableOff;



    


    private void Update()
    {
  
            
                if (Bomb1 == true)
                {
                    if (Bomb2 == true)
                    {
                        if (Bomb3 == true)
                        {
                           
                            CraftableTableOn.SetActive(true);
                            TableOff.SetActive(false);
                           
                        }
                    }
                }

            
       



    }
}

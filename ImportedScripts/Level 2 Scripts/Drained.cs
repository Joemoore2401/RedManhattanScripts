using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drained : MonoBehaviour
{
    public static bool Interacted = false;
    public bool hasTNT = false;
    public GameObject Drain;
    public GameObject RadioactiveWater;
    public GameObject TNTHighlightOff;
    public GameObject TNTPlanted;
    public GameObject InteractionUI;
    public GameObject ObjectiveOff;
    public GameObject ObjectiveOn;



    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            InteractionUI.SetActive(true);
            Interacted = true;
            GameObject player = collision.GetComponent<GameObject>();

        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            InteractionUI.SetActive(false);
            Interacted = false;
            GameObject player = collision.GetComponent<GameObject>();

        }
    }


    private void Update()
    {
        if (Interacted == true)
        {
            if (hasTNT == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Interacted = false;
                    InteractionUI.SetActive(false);
                    TNTPlanted.SetActive(true);
                    ObjectiveOff.SetActive(false);
                    ObjectiveOn.SetActive(true);
                    RadioactiveWater.SetActive(false);
                    Drain.SetActive(true);
                    TNTPlanted.SetActive(true);
                    TNTHighlightOff.SetActive(false);
                    
                    
                }
            }


        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingAcid : MonoBehaviour
{

    public static bool Interacted = false;
    public bool hasTNT = false;
    public GameObject GuardDown;
    public GameObject GuardDown2;
    public GameObject UIOff;
    public GameObject ObjectiveOff;
    public GameObject ObjectiveOn;
    public GameObject GuardScreaming;
    public GameObject InteractionUI;
    public GameObject Floppydisc;
    public GameObject TriggerOff;

         
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Interacted = true;
            InteractionUI.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Interacted = false;
            InteractionUI.SetActive(false);
        }
    }


    private void Update()
    {
        if (Interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(hasTNT == true)
                {
                    InteractionUI.SetActive(false);
                    GuardScreaming.SetActive(true);
                    GuardDown2.SetActive(false);
                    UIOff.SetActive(false);
                    GuardDown.SetActive(false);
                    ObjectiveOff.SetActive(false);
                    ObjectiveOn.SetActive(true);
                    Floppydisc.SetActive(true);
                    TriggerOff.SetActive(false);
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator Access;
    public static bool interacted;
    public GameObject InteractionUI;
    public GameObject TriggerOff;
    public GameObject Sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interacted = true;
            InteractionUI.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interacted = false;
            InteractionUI.SetActive(false);
            
        }
    }

    private void Update()
    {
        if (interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InteractionUI.SetActive(false);
                Sound.SetActive(true);
                Access.SetTrigger("Accessed");
                TriggerOff.SetActive(false);
            }
        }
    }
}

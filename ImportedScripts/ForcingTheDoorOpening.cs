using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcingTheDoorOpening : MonoBehaviour
{
    public GameObject InteractionText;
    public Animator Accessing;
    public bool hammerAcquired = false;
    public bool inTrigger = false;

    private void Update()
    {
        if (inTrigger == true)
        {

            InteractionText.SetActive(true);
            
            if(hammerAcquired== true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Accessing.SetTrigger("Accessed");
                }
            }
            
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.CompareTag("Player"))
            {
                inTrigger = true;
            }


        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }
}

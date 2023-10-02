using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingDoor : MonoBehaviour
{
    public GameObject InteractionUI;
    public static bool interacted;
    public Animator Door1;
    public GameObject NonTableActive;
    public GameObject ObjectiveOff;
    public GameObject ObjectiveOn;
    public GameObject TableDeactive;
    public GameObject TableOn;
    public GameObject TableOff;
    public GameObject sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractionUI.SetActive(true);
            interacted = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractionUI.SetActive(false);
            interacted = false;
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InteractionUI.SetActive(false);
                Door1.SetTrigger("Accessed");
                sound.SetActive(true);
                ObjectiveOff.SetActive(false);
                ObjectiveOn.SetActive(true);
                TableDeactive.SetActive(false);
                NonTableActive.SetActive(true);
                TableOff.SetActive(false);
                TableOn.SetActive(true);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockdownOff : MonoBehaviour
{
    public GameObject InteractionUI;
    public static bool interacted;
    public Animator Door1;
    public Animator Door2;
    public Animator Door3;
    public GameObject meshActive;
    public GameObject AlarmDisabled;
    public GameObject sound;
    public GameObject ObjectiveOn;
    public GameObject ObjectiveOff;



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
                Door2.SetTrigger("Accessed");
                Door3.SetTrigger("Accessed");
                ObjectiveOff.SetActive(false);
                ObjectiveOn.SetActive(true);
                sound.SetActive(true);
                meshActive.SetActive(true);
                AlarmDisabled.SetActive(false);
            }
        }
    }
}

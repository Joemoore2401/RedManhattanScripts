using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeActive : MonoBehaviour
{
    public GameObject Dialouge;
    public GameObject CountdownText;
    public GameObject InteractionText;
    public GameObject OfficerTextDisabled;
    public GameObject Smoke;
    public GameObject Ticking;
    public GameObject GuardGone;
    public GameObject DoorTrigger;
    public bool InTrigger = false;
    public CountdownScript timeScript;
    public Animator Disappear;
    public GameObject GuardModel;
    public GameObject ObjectiveOn;
    public GameObject ObjectiveOff;
    public GameObject AmbienceOff;
    public GameObject AmbienceOn;


    void Update()
    {
        if (InTrigger == true)
        {
            InteractionText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {

                //Trigger the countdown.
                timeScript.StartCountdown();

                
                InteractionText.SetActive(false);
                Smoke.SetActive(true);
                CountdownText.SetActive(true);
                Ticking.SetActive(true);
                OfficerTextDisabled.SetActive(false);
                GuardGone.SetActive(false);
                AmbienceOff.SetActive(false);
                AmbienceOn.SetActive(true);
                DoorTrigger.SetActive(true);
                ObjectiveOff.SetActive(false);
                ObjectiveOn.SetActive(true);
                GuardModel.SetActive(false);
                Dialouge.SetActive(true);
                this.GetComponent<MeshRenderer>().enabled = false;
                Disappear.SetTrigger("Teleport");
                //Destroy(this.gameObject);

            }


        }
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            InteractionText.SetActive(true);
            InTrigger = true;

          
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractionText.SetActive(false);
            InTrigger = false;
        }
    }

    
}

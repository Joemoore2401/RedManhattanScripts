using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingAlarm : MonoBehaviour
{
    public bool hasTNT;
    public GameObject CountdownText;
    public GameObject InteractionText;
    public GameObject Ticking;
    public GameObject GuardGone;
    public GameObject Guard;
    public GameObject placed;
    public GameObject ObjectiveOff;
    public GameObject ObjectiveOn;
    public GameObject UIDissapear;
    public GameObject ambience;
    public GameObject HighlightGone;
    public bool InTrigger = false;
    public GameObject TimerActive;
    public Animator Disappear;


    void Update()
    {
        if (InTrigger == true)
        {
            InteractionText.SetActive(true);

            if (hasTNT == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    //Trigger the countdown.

                    ObjectiveOff.SetActive(false);
                    ObjectiveOn.SetActive(true);
                    InteractionText.SetActive(false);
                    ambience.SetActive(false);
                    TimerActive.SetActive(true);
                    Guard.SetActive(false);
                    CountdownText.SetActive(true);
                    Ticking.SetActive(true);
                    UIDissapear.SetActive(false);
                    HighlightGone.SetActive(false);
                    GuardGone.SetActive(false);
                    placed.SetActive(true);
                    this.GetComponent<MeshRenderer>().enabled = false;
                    Disappear.SetTrigger("Triggered");
                    //Destroy(this.gameObject);

                }

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

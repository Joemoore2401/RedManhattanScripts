using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacingMolatov : MonoBehaviour
{
    public bool hasTNT;
    public GameObject InteractionText;
    public GameObject placed;
    public GameObject FireSequence;
    public GameObject DeskActive;
    public GameObject NonDeskDeactive;
    public GameObject ObjectiveOff;
    public GameObject ObjectiveOn;
    public GameObject UIDissapear;
    public GameObject placednoise;
    public GameObject HighlightGone;
    public bool InTrigger = false;
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



                    DeskActive.SetActive(true);
                    NonDeskDeactive.SetActive(false);
                    FireSequence.SetActive(true);
                    InteractionText.SetActive(false);
                    placed.SetActive(true);
                    ObjectiveOff.SetActive(false);
                    placednoise.SetActive(true);
                    ObjectiveOn.SetActive(true);
                    UIDissapear.SetActive(false);
                    HighlightGone.SetActive(false);
                    FireSequence.SetActive(true);
                    this.GetComponent<MeshRenderer>().enabled = false;
                    Disappear.SetTrigger("Triggered");
                   

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBomb : MonoBehaviour
{
     public bool hasTNT = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject TNTUI;
    public GameObject ObjectiveOff1;
    public GameObject ObjectiveOff2;
    public GameObject ObjectiveOff3;
    public GameObject ObjectiveOff4;
    public GameObject ObjectiveOn;
    public GameObject GuardInteractionoff;
    public GameObject Highlight;
    public GameObject PickedUp;
    public StartingAlarm startingAlarm;
    public GameObject floppydisc;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))

            InteractionUI.SetActive(true);
        Interacted = true;
        player = collision.GetComponent<GameObject>();



    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))

            InteractionUI.SetActive(false);
        Interacted = false;
        player = collision.GetComponent<GameObject>();



    }

    void Update()
    {
        if (Interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                hasTNT = true;
                startingAlarm.hasTNT = true;
                InteractionUI.SetActive(false);
                TNTUI.SetActive(true);
                ObjectiveOff1.SetActive(false);
                ObjectiveOff2.SetActive(false);
                ObjectiveOff3.SetActive(false);
                ObjectiveOff4.SetActive(false);
                ObjectiveOn.SetActive(true);
                Highlight.SetActive(true);
                floppydisc.SetActive(true);
                Destroy(GuardInteractionoff);
                PickedUp.SetActive(true);
                Destroy(this.gameObject);
                StartCoroutine(TextGone());
                IEnumerator TextGone()
                {
                    yield return new WaitForSeconds(2);

                }

            }

        }

    }
}

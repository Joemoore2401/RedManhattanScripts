using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyWithObjective : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject KeyUI;
    public GameObject ObjectiveOff;
    public GameObject ObjectiveOn;
    public GameObject PickedUp;
    public HallwayDoorScript nonTimerDoorScript;


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




    }

    void Update()
    {
        if (Interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                hasKey = true;
                PickedUp.SetActive(true);
                nonTimerDoorScript.hasKey = true;
                Interacted = false;
                ObjectiveOff.SetActive(false);
                ObjectiveOn.SetActive(true);
                InteractionUI.SetActive(false);
                KeyUI.SetActive(true);
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

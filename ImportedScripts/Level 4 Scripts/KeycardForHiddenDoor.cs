using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardForHiddenDoor : MonoBehaviour
{
    public static bool Interacted = false;
    public GameObject InteractionUI;
    public bool hasKey = false;
    public GameObject player;
    public GameObject TableOff;
    public GameObject TableOn;
    public GameObject KeyUI;

    public UnlockingTheHiddenDoor nonTimerDoorScript;


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
                InteractionUI.SetActive(false);
                hasKey = true;
                nonTimerDoorScript.hasKey = true;
                TableOff.SetActive(false);
                TableOn.SetActive(true);
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

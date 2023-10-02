using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnersHammer : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject KeyUI;
    public BrakingOpenDoor doorScript;
    public GameObject PickedUp;
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
                doorScript.hasKey = true;
                Interacted = false;
                InteractionUI.SetActive(false);
                KeyUI.SetActive(true);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidBomb : MonoBehaviour
{
    public bool hasTNT = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject TNTUI;
    public GameObject GuardInteractionoff;
    public GameObject AcidTrigger;
    public GameObject ObjectiveOff1;
    public GameObject ObjectiveOff2;
    public GameObject ObjectiveOn;
    public GameObject PickedUp;
    public ThrowingAcid throwingAcid;
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

                hasTNT = true;
                throwingAcid.hasTNT = true;
                Interacted = false;
                InteractionUI.SetActive(false);
                TNTUI.SetActive(true);
                AcidTrigger.SetActive(true);
                ObjectiveOff1.SetActive(false);
                ObjectiveOff2.SetActive(false);
                ObjectiveOn.SetActive(true);
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

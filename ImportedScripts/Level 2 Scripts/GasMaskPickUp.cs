using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasMaskPickUp : MonoBehaviour
{
    public bool hasTNT = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject TNTUI;
    public GameObject PickedUp;
    public Drained drained;
    public GameObject HighlightOn;
    public GameObject ObjectiveOn;
    public GameObject ObjectiveOff;
    public GameObject HighlightOff;
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
                drained.hasTNT = true;
                Interacted = false;
                InteractionUI.SetActive(false);
                TNTUI.SetActive(true);
                HighlightOn.SetActive(true);
                HighlightOff.SetActive(false);
                ObjectiveOn.SetActive(true);
                ObjectiveOff.SetActive(false);
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molatov : MonoBehaviour
{
    public bool hasTNT = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject TNTUI;
    public GameObject Highlight;
    public GameObject PickedUp;
    public PlacingMolatov placingMolatov;
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
                placingMolatov.hasTNT = true;
                Interacted = false;
                InteractionUI.SetActive(false);
                TNTUI.SetActive(true);
                Highlight.SetActive(true);
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

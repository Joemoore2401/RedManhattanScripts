using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNTPickUp : MonoBehaviour
{
    public bool hasTNT = false;
    public GameObject InteractionUI;
    public static bool interacted = false;
    public GameObject player;
    public GameObject TNTUI;
    public GameObject BombPlacer;
    public GameObject PickedUp;
    public Explode bombExplosion;
    public GameObject ObjectiveOff;
    public GameObject ObjectiveOn;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))

            InteractionUI.SetActive(true);
        interacted = true;
        player = collision.GetComponent<GameObject>();



    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))

            InteractionUI.SetActive(false);
        interacted = false;




    }

    void Update()
    {
        if (interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                hasTNT = true;
                ObjectiveOff.SetActive(false);
                ObjectiveOn.SetActive(true);
                bombExplosion.hasTNT = true;
                interacted = false;
                InteractionUI.SetActive(false);
                TNTUI.SetActive(true);
                BombPlacer.SetActive(true);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3 : MonoBehaviour
{
    public bool Bomb3 = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject BombUI;
    public GameObject PickedUp;
    public CreatingTheBomb creatingTheBomb;
    public CreatingAcidBomb creatingAcidBomb;

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

                Bomb3 = true;
                Interacted = false;
                InteractionUI.SetActive(false);
                PickedUp.SetActive(true);
                creatingTheBomb.Bomb3 = true;
                creatingAcidBomb.Bomb3 = true;
                BombUI.SetActive(true);
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

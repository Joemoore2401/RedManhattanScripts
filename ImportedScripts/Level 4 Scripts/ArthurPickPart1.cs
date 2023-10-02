using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArthurPickPart1 : MonoBehaviour
{
    public bool Bomb1 = false;
    public GameObject InteractionUI;
    public static bool Interacted = false;
    public GameObject player;
    public GameObject BombUI;
    public MakingPickLock makingPickLock;
    public PartsForBombDoor parts;

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

                Bomb1 = true;
                Interacted = false;
                InteractionUI.SetActive(false);
                makingPickLock.Bomb1 = true;
                parts.Bomb1 = true;
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

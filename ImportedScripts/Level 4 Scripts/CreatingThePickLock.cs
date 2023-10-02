using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingThePickLock : MonoBehaviour
{
    public static bool Interacted = false;
    public bool Bomb1 = false;
    public bool Bomb2 = false;
    public GameObject UIOff1;
    public GameObject UIOff2;
    public GameObject TNT;
    public GameObject InteractionUI;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            InteractionUI.SetActive(true);
            Interacted = true;
            GameObject player = collision.GetComponent<GameObject>();

        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            InteractionUI.SetActive(false);
            Interacted = false;
            GameObject player = collision.GetComponent<GameObject>();

        }
    }


    private void Update()
    {
        if (Interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Bomb1 == true)
                {
                    if (Bomb2 == true)
                    {
                        UIOff1.SetActive(false);
                        UIOff2.SetActive(false);
                        TNT.SetActive(true);
                        Interacted = false;
                        InteractionUI.SetActive(false);
                        Destroy(GetComponent<Collider>());
                        StartCoroutine(TextOff());
                        IEnumerator TextOff()
                        {
                            yield return new WaitForSeconds(2);
                        }
                    }
                }

            }
        }



    }
}

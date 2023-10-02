using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingTheHiddenDoor : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject UIOff;
    public GameObject InteractionUI;
    public Animator _door;
    public GameObject _sound;
    public static bool interacted = false;
    public GameObject TableOff;
    public GameObject TableOn;




    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject player = collision.GetComponent<GameObject>();
            InteractionUI.SetActive(true);
            interacted = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {

            InteractionUI.SetActive(false);
            interacted = false;
        }
    }
    private void Update()
    {
        if (interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasKey == true)
                {

                    _door.SetTrigger("Accessed");
                    UIOff.SetActive(false);
                    _sound.SetActive(true);
                    InteractionUI.SetActive(false);
                    TableOff.SetActive(false);
                    TableOn.SetActive(true);
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

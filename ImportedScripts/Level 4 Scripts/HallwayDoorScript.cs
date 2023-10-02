using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayDoorScript : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject UIOff;
    public GameObject InteractionUI;
    public GameObject ColliderOut;
    public Animator _door;
    public GameObject _sound;
    public static bool interacted = false;




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
                    ColliderOut.SetActive(false);
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

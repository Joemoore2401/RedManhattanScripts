using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakingOpenDoor : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject UIOff;
    public Animator _door;
    public GameObject _sound;
    public GameObject InteractionUI;
    public GameObject triggerOff;
    public static bool interacted;



    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject player = collision.GetComponent<GameObject>();
            interacted = true;
            InteractionUI.SetActive(true);
            
            
          
        }
    }


    private void OnTriggerExit(Collider other)
    {
        interacted = false;
        InteractionUI.SetActive(false);
    }

    private void Update()
    {
        if(interacted == true)
        {
            if (hasKey == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    _door.SetTrigger("Accessed");
                    UIOff.SetActive(false);
                    InteractionUI.SetActive(false);
                    triggerOff.SetActive(false);
                    _sound.SetActive(true);
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

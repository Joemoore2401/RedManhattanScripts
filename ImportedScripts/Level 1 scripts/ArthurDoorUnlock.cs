using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArthurDoorUnlock : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject UIOff;
    public Animator _door;
    public GameObject _sound;
    public GameObject Ticking;
    public GameObject CountdownText;
    public ArthursLevel1Countdown arthursLevel1Countdown;
    public static bool interacted;
    public GameObject InteractionUI;
    public GameObject TriggerOff;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            interacted = true;
            InteractionUI.SetActive(true);
            GameObject player = collision.GetComponent<GameObject>();
            
           
        }
    }


    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            interacted = false;
            InteractionUI.SetActive(false);
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
                    arthursLevel1Countdown.countdownStop = true;
                    _door.SetTrigger("Accessed");
                    Ticking.SetActive(false);
                    UIOff.SetActive(false);
                    InteractionUI.SetActive(false);
                    TriggerOff.SetActive(false);
                    _sound.SetActive(true);
                    CountdownText.SetActive(false);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombinteraction : MonoBehaviour
{
    public GameObject CivilianTalking;
    public GameObject CountdownText;
    public Level4Timer timerScript;
    public static bool interacted;
    public GameObject InteractionUI;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            interacted = true;
            GameObject player = collision.GetComponent<GameObject>();
            InteractionUI.SetActive(true);


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
                CivilianTalking.SetActive(true);
                Destroy(GetComponent<Collider>());
                InteractionUI.SetActive(false);
                timerScript.countdownStop = true;
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

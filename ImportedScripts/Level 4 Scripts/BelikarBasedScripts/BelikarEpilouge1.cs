using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BelikarEpilouge1 : MonoBehaviour
{
    public GameObject InteractionUI;
    public static bool interacted;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractionUI.SetActive(true);
            interacted = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractionUI.SetActive(false);
            interacted = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                InteractionUI.SetActive(false);
                SceneManager.LoadScene("BelikarEpilouge1");
            }
        }
    }
}

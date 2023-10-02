using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingSceneForBelikar : MonoBehaviour
{

    public static bool interacted;
    public GameObject InteractionUI;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interacted = true;
            InteractionUI.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
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
                SceneManager.LoadScene("BelikarMonolouge");
            }
        }
    }
}

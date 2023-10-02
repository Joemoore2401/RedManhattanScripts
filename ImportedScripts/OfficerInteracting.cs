using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class OfficerInteracting : MonoBehaviour
{
    public GameObject DialougeFlowChart;
    public GameObject InteractionText;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            InteractionText.SetActive(true);


        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DialougeFlowChart.SetActive(true);
                InteractionText.SetActive(false);
            }


        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            InteractionText.SetActive(false);
            

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeInteraction : MonoBehaviour
{
    public GameObject CivilianTalking;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CivilianTalking.SetActive(true);
            Destroy(GetComponent<Collider>());
        }
    }
}

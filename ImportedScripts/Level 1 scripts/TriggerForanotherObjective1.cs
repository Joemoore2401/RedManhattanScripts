using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForanotherObjective1 : MonoBehaviour
{
    public GameObject ObjectiveOn;
    public GameObject ObjectiveOff;
    public GameObject TriggerOff;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ObjectiveOff.SetActive(false);
            ObjectiveOn.SetActive(true);
            TriggerOff.SetActive(false);
        }
    }
}

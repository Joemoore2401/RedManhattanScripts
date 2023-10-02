using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTrainDoor : MonoBehaviour
{
    public Animator OpeningDoor;
    public GameObject DisableDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Slider());
        }


        IEnumerator Slider()
        {
            yield return new WaitForSeconds(2);
            DisableDoor.SetActive(false);
            OpeningDoor.SetTrigger("OpenUp");
        }
    }

}

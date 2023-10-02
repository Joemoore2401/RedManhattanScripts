using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Sticking : MonoBehaviour
{
    public GameObject Player;
    public GameObject TrainObject;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.parent = TrainObject.transform;
        StartCoroutine(Unsticking());
    }

    IEnumerator Unsticking()
    {
        yield return new WaitForSeconds(10);
        Player.transform.parent = null;
    }
}

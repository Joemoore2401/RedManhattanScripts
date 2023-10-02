using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceOfFlames : MonoBehaviour
{
    public GameObject fire;
    public GameObject DeathTriggerFire;
    public GameObject smoke;
    public GameObject placed;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TextGone());
        IEnumerator TextGone()
        {
            yield return new WaitForSeconds(5);
            placed.SetActive(false);
            fire.SetActive(true);
            DeathTriggerFire.SetActive(true);
            placed.SetActive(false);
            yield return new WaitForSeconds(5);
            smoke.SetActive(true);

        }
    }
}

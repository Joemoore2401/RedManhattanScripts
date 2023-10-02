using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnerFloppyDiscFromGuard : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject player;
    public GameObject TableOff;
    public GameObject TableOn;
    public GameObject KeyUI;

    public NonTimerDoorScript nonTimerDoorScript;

  

    void Update()
    {

            

                hasKey = true;
                nonTimerDoorScript.hasKey = true;
                TableOff.SetActive(false);
                TableOn.SetActive(true);
                KeyUI.SetActive(true);
                Destroy(this.gameObject);
                StartCoroutine(TextGone());
                IEnumerator TextGone()
                {
                    yield return new WaitForSeconds(2);

                }

            

        

    }
}

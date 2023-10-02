using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArthursDiscFromGuard : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject player;
    public GameObject KeyUI;

    public ArthurNextScene nonTimerDoorScript;



    void Update()
    {



        hasKey = true;
        nonTimerDoorScript.hasKey = true;
        KeyUI.SetActive(true);
        Destroy(this.gameObject);
        StartCoroutine(TextGone());
        IEnumerator TextGone()
        {
            yield return new WaitForSeconds(2);

        }





    }
}

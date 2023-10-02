using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArthurNextScene : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject UIOff;
    public GameObject InteractionUI;
    public static bool interacted = false;




    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject player = collision.GetComponent<GameObject>();
            InteractionUI.SetActive(true);
            interacted = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {

            InteractionUI.SetActive(false);
            interacted = false;
        }
    }
    private void Update()
    {
        if (interacted == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasKey == true)
                {

                    UIOff.SetActive(false);
                    InteractionUI.SetActive(false);
                    SceneManager.LoadScene("ArthurMonolouge4");
                    StartCoroutine(TextOff());
                    IEnumerator TextOff()
                    {
                        yield return new WaitForSeconds(2);
                    }


                }
            }
        }



    }
}

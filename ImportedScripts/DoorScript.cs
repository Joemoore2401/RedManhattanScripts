using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool hasKey = false;
    public GameObject UIOff;
    public Animator _door;
    public AudioSource _sound;
    public GameObject Ticking;
    public GameObject CountdownText;
    public CountdownScript timerScript;
    

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject player = collision.GetComponent<GameObject>();
            if (hasKey == true)
            {
                timerScript.countdownStop = true;
                _door.SetTrigger("Accessed");
                Ticking.SetActive(false);
                UIOff.SetActive(false);
                _sound.Play();
                CountdownText.SetActive(false);
                Destroy(GetComponent<Collider>());
                StartCoroutine(TextOff());
                IEnumerator TextOff()
                {
                    yield return new WaitForSeconds(2);
                }


            }
            
        }
    }
  
}

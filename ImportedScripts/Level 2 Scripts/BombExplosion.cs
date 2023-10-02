using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosion : MonoBehaviour
{
    public static bool Interacted = false;
    public bool hasTNT = false;
    public GameObject Explosion;
    public AudioSource Bang;
    public GameObject TNTUIOff;
    public GameObject DeathSpread;
    public GameObject RadioactiveWater;
    public GameObject TNTHighlightOff;
    public GameObject TNTPlanted;
    public GameObject InteractionUI;
    public GameObject ObjectiveOff1;
    public GameObject ObjectiveOn1;
    public GameObject ObjectiveOff2;
    public GameObject ObjectiveOn2;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            InteractionUI.SetActive(true);
            Interacted = true;
            GameObject player = collision.GetComponent<GameObject>();

        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            InteractionUI.SetActive(false);
            Interacted = false;


        }
    }


    private void Update()
    {
        if (Interacted == true)
        {
           if (hasTNT == true)
           {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    InteractionUI.SetActive(false);
                    TNTHighlightOff.SetActive(false);
                    TNTUIOff.SetActive(false);
                    TNTPlanted.SetActive(true);
                    ObjectiveOff1.SetActive(false);
                    ObjectiveOn1.SetActive(true);
                    Destroy(GetComponent<MeshCollider>());
                    Destroy(GetComponent<Collider>());
                    StartCoroutine(BombClearence());
                    IEnumerator BombClearence()
                    {
                        yield return new WaitForSeconds(5);
                        RadioactiveWater.SetActive(false);
                        DeathSpread.SetActive(true);
                        Explosion.SetActive(true);
                        Bang.Play();
                        TNTPlanted.SetActive(false);
                        yield return new WaitForSeconds(2);
                        ObjectiveOff2.SetActive(false);
                        ObjectiveOn2.SetActive(true);
                        DeathSpread.SetActive(false);
                        TNTHighlightOff.SetActive(false);
                    }

                }
           }
            
            
        }



    }
}

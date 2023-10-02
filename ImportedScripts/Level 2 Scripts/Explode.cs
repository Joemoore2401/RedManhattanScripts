using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public static bool Interacted = false;
    public bool BombOn = false;
    public bool hasTNT = false;
    public GameObject TNTUIOff;
    public GameObject TNTPlanted;
    public GameObject InteractionUI;
    public GameObject Planted;
    public GameObject ObjectiveOff1;
    public GameObject ObjectiveOn1;
    public GameObject TNTOff;
    public ExplodeSequencing Boom;


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
                    Planted.SetActive(true);
                    TNTUIOff.SetActive(false);
                    TNTPlanted.SetActive(true);
                    ObjectiveOff1.SetActive(false);
                    ObjectiveOn1.SetActive(true);
                    Destroy(GetComponent<MeshCollider>());
                    Destroy(GetComponent<Collider>());
                    BombOn = true;
                    Boom.BombOn = true;
                    TNTOff.SetActive(false);

                  


                  
                }


            }


        }
       


    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part1FromCivilian : MonoBehaviour
{
    public bool Bomb1 = false;
    public GameObject player;
    public GameObject BombUI;
    public CreatingTheBomb creatingTheBomb;
    public CreatingAcidBomb creatingAcidBomb;

    

    void Update()
    {
       

                Bomb1 = true;
                creatingTheBomb.Bomb1 = true;
                creatingAcidBomb.Bomb1 = true;
                BombUI.SetActive(true);
                Destroy(this.gameObject);
                StartCoroutine(TextGone());
                IEnumerator TextGone()
                {
                    yield return new WaitForSeconds(2);

                }

            

        

    }
}

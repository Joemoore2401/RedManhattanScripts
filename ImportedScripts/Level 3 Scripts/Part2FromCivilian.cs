using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part2FromCivilian : MonoBehaviour
{
    public bool Bomb2 = false;
    public GameObject player;
    public GameObject BombUI;
    public CreatingTheBomb creatingTheBomb;
    public CreatingAcidBomb creatingAcidBomb;



    void Update()
    {


        Bomb2 = true;
        creatingTheBomb.Bomb2 = true;
        creatingAcidBomb.Bomb2 = true;
        BombUI.SetActive(true);
        Destroy(this.gameObject);
        StartCoroutine(TextGone());
        IEnumerator TextGone()
        {
            yield return new WaitForSeconds(2);

        }





    }
}

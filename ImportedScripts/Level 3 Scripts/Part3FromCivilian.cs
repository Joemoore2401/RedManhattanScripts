using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3FromCivilian : MonoBehaviour
{
    public bool Bomb3 = false;
    public GameObject player;
    public GameObject BombUI;
    public CreatingTheBomb creatingTheBomb;
    public CreatingAcidBomb creatingAcidBomb;



    void Update()
    {


        Bomb3 = true;
        creatingTheBomb.Bomb3 = true;
        creatingAcidBomb.Bomb3 = true;
        BombUI.SetActive(true);
        Destroy(this.gameObject);
        StartCoroutine(TextGone());
        IEnumerator TextGone()
        {
            yield return new WaitForSeconds(2);

        }





    }
}

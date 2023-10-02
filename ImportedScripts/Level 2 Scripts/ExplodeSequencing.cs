using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeSequencing : MonoBehaviour
{
    public bool BombOn = false;
    public GameObject Explosion;
    public GameObject Alarm;
    public GameObject Bang;
    public GameObject DeathSpread;
    public GameObject RadioactiveWater;
    public GameObject TNTPlanted;
    public GameObject ObjectiveOff2;
    public GameObject ObjectiveOn2;



    private void Update()
    {
        if (BombOn == true)
        {
            StartCoroutine(BombClearence());
            IEnumerator BombClearence()
            {
                Alarm.SetActive(true);
                yield return new WaitForSeconds(5);
                RadioactiveWater.SetActive(false);
                DeathSpread.SetActive(true);
                Explosion.SetActive(true);
                Bang.SetActive(true);
                Alarm.SetActive(false);
                TNTPlanted.SetActive(false);
                yield return new WaitForSeconds(2);
                Destroy(DeathSpread);
                Destroy(Alarm);
                ObjectiveOff2.SetActive(false);
                ObjectiveOn2.SetActive(true);
                TNTPlanted.SetActive(false);

            }
        }
    
    
   



    }
}

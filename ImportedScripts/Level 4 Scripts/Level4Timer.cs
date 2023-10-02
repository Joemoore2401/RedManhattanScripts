using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level4Timer : MonoBehaviour
{
    public int timer;
    public int timerStart;
    public bool countdownStop;
    public GameObject CountdownActive;

    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        CountdownActive.SetActive(true);
        timer = timerStart;
        StartCountdown();
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = timer.ToString("0");

        Debug.Log("Time remaining: " + timer);





        if (timer == 0)
        {
            CountdownActive.SetActive(false);
            SceneManager.LoadScene("ArthurFinalLevelGameOver");

            //This is what happens when the timer runs out.
            Debug.Log("Oh no!");
        }
    }

    public void StartCountdown()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {

        yield return new WaitForSeconds(1f);

        if (!countdownStop)
        {
            timer--;

        }

        if (timer > 0 && !countdownStop)
        {
            StartCoroutine(Countdown());
        }

    }
}

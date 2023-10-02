using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownScript : MonoBehaviour
{
    public int timer;
    public int timerStart;
    public bool countdownStop;
    
    
    public Text countdownText;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = timerStart;
        //StartCountdown();
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = timer.ToString("0");

        Debug.Log("Time remaining: " + timer);

        
        


        if(timer == 0) 
        {
            SceneManager.LoadScene("ConnerLevel1GameOverScene");
            
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

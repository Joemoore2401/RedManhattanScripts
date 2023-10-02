using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{
    // Start is called before the first frame update

   
   

    public void EasyLevel()
   {
        SceneManager.LoadScene("SampleScene");
   }

   public void MediumLevel()
   {
       SceneManager.LoadScene("ArthurMonolouge");
   }
   public void HardLevel()
   {
       SceneManager.LoadScene("ConnerMonolouge");
   }

   public void ConnerLevel1()
   {
       SceneManager.LoadScene("ConnerLevel1");
   }
    public void ConnerLevel2()
    {
        SceneManager.LoadScene("ConnerLevel2");
    }
    public void ArthurLevel2()
    {
        SceneManager.LoadScene("ArthurLevel2");
    }
    public void ConnerLevel3()
    {
        SceneManager.LoadScene("ConnerLevel3");
    }
    public void ArthurLevel3()
    {
        SceneManager.LoadScene("ArthurLevel3");
    }
    public void ArthurLevel4()
    {
        SceneManager.LoadScene("ArthurFinalLevel");
    }
    public void BelikarFinalLevel()
    {
        SceneManager.LoadScene("BelikarFinalLevel");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

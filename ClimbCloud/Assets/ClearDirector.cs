using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//LoadSceneを使う為の宣言

public class ClearDirector : MonoBehaviour
{
    public Text ClearTime;
    public Text BestTime;
    //float bestTime = 99.0f;

    void Start()
    {
        float CurrentTime = PlayerPrefs.GetFloat("CurrentTime");

        ClearTime.text = string.Format("{0:0.00}", CurrentTime);

        if (PlayerPrefs.HasKey("BestTime") == false)
        {
            PlayerPrefs.SetFloat("BestTime", CurrentTime+1.0f);
            PlayerPrefs.Save();
        }

        float fBestTime = PlayerPrefs.GetFloat("BestTime");

        if (CurrentTime < fBestTime)
        {
            PlayerPrefs.SetFloat("BestTime", CurrentTime);
            PlayerPrefs.Save();
            fBestTime = CurrentTime;
        }
       
        BestTime.text = string.Format("{0:0.00}", fBestTime);


    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");

        }
    }
}

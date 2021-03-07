using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge;
    public GameObject GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        //this.hpGauge = GameObject.Find("hpGauge");
        GameOverText.SetActive(false);
    }
    


    public void DecreaseHp()
    {
        //this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

        if (hpGauge.fillAmount > 0)
        {
            hpGauge.fillAmount -= 0.1f;

            if (hpGauge.fillAmount <= 0)
            {
                GameOver();
            }
        }
    }

    public void GameOver()
    {
        GameOverText.SetActive(true);
    }
}
    
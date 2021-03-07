using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;  //GameObject型の変数の宣言
    Color textcolor;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance"); //GameObject型の変数にGameSceneに置いた実際のObjectを結びつける
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "ゴールまで" + length.ToString("F2") + "m";
        ColorUtility.TryParseHtmlString("#323232", out textcolor);

        if (length >= -3.0f && length <= 5.0f)
        {
            this.distance.GetComponent<Text>().text = "Excellent!!\r\nゴールまで" + length.ToString("F2") + "m";
            ColorUtility.TryParseHtmlString("#FF0000", out textcolor);
        }
        else if (length <= -4.75f)
        {
            this.distance.GetComponent<Text>().text = "Game Over!";
            ColorUtility.TryParseHtmlString("#00008B", out textcolor);
        }
        this.distance.GetComponent<Text>().color = textcolor;
    }

    public void Restart()//リスタートのメソッド。ボタンが押された際に最初のシーンを再び読み込むようにしている。
    {
        SceneManager.LoadScene("GameScene");


    }



}

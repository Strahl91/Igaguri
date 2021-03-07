using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    float starttime;
    public float Topspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スワイプの長さを求める
        if (Input.GetMouseButtonDown(0)) //マウスがクリックされたら
        {
            //マウスをクリックした座標
            this.startPos = Input.mousePosition;
            starttime = Time.time;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            //マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;
            float endtime = Time.time;
            float deltatime = endtime - starttime;

            //スワイプの長さを初速度に設定する(追加：スワイプの時間に応じて車の移動距離が変化)
            this.speed = swipeLength / (500 * deltatime);
            Topspeed = this.speed;

            //効果音再生
            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0, 0); //移動
        this.speed *= 0.98f;                   //減速
    }
}

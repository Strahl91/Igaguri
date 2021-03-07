using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    [SerializeField]  //デバッグ用にインスペクターに表示することができる
    private float speed = 1.0f;//他のスクリプトで直接変数を操作されないようにする為にはprivate型の変数を使用する

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        //フレーム毎に等速で落下させる
        transform.Translate(0, -0.1f * speed, 0);

        //画面外に出たらオブジェクトを破棄する
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;              //矢の中心座標
        Vector2 p2 = this.player.transform.position; //playerの中心座標
        Vector2 dir = p1 - p2;                      //playerから矢へのベクトル
        float d = dir.magnitude;                   //ベクトルdirの長さをdと定義
        float r1 = 0.5f;                          //矢の半径
        float r2 = 1.0f;                         //playerの半径

        if (d < r1 + r2)
        {
            //監督スクリプトにプレイヤーと衝突した事を伝える
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //衝突した場合、矢を消す
            Destroy(gameObject);
        }
    }

    public void Setspeed(float rate)//矢のスピードに上下限を設定するメソッド。ArrowGeneratorからアクセスできるようにPublic型とした。
    {
        if (rate < 0.5)
        {
            rate = 0.5f;
        }
        else if (rate > 2)
        {
            rate = 2.0f;
        }
        speed = rate;
    }



}

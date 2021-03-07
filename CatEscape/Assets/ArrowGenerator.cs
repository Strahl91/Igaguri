using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject[] arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    int PrefabIndex = 0;

    // Update is called once per frame
    void Update()
    { 
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab[PrefabIndex]) as GameObject;//矢のPrefabを元に矢を生成する。新しく作る矢はgoというオブジェクト型の変数で以降指示する。
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
            //int rate = Random.Range(0, 3);
            //go.GetComponent<ArrowController>().Setspeed(rate);//オブジェクト変数goに付けられたArrowControllerのスクリプト内のSetspeedメソッドを使う。

            //３種類の矢を順番に読み出す（追加）
            PrefabIndex++;
            //PrefabIndex %= arrowPrefab.Length;
            if (PrefabIndex >= arrowPrefab.Length)
            {
                PrefabIndex = 0;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    GameObject target;
    public bool TargetMoveDir = true;

    // Start is called before the first frame update
    void Start()
    {
        this.target = GameObject.Find("target");

    }

    // Update is called once per frame
    void Update()
    {
        //的の座標を20になるまで増やす。20になったら-20まで減らす
        if (TargetMoveDir == true)
        {
            transform.Translate(0.5f, 0, 0);
            if (this.target.transform.position.x >= 20)
            {
                TargetMoveDir = false;
            }
        }
        else
        {
            transform.Translate(-0.5f, 0, 0);
            if (this.target.transform.position.x <= -20)
            {
                TargetMoveDir = true;
            }
        }





    }
}

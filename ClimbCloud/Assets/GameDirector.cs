using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public float StartTime = 0;
    GameObject PlayTime;
    public GameObject NearGoal;


    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
        this.PlayTime = GameObject.Find("Text");

    }

    // Update is called once per frame
    void Update()
    {
        
        float ClearTime = GetPlayTime();

        this.PlayTime.GetComponent<Text>().text = string.Format("{0:0.00}", ClearTime);
    }

    public float GetPlayTime()
    {
        return Time.time - StartTime;
    }
}

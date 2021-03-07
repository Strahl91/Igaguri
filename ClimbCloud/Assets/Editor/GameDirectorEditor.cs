using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameDirector))]
public class GameDirectorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GameDirector script = target as GameDirector;
        base.OnInspectorGUI();

        if (GUILayout.Button("ClearBestTime"))
        {
            PlayerPrefs.DeleteKey("BestTime");
            Debug.Log("クリアBestTime");
        }

        if (GUILayout.Button("NearGoal"))
        {
            script.NearGoal.SetActive(!script.NearGoal.activeSelf);

        }
    }
}
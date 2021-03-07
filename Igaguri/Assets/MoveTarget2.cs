using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget2 : MonoBehaviour
{
    public float m_fSwing;
    public float m_fInterval;

    // Update is called once per frame
    void Update()
    {
        float f = 1.0f / m_fInterval;
        float cos = m_fSwing * Mathf.Cos(2 * Mathf.PI * f * Time.time);
        float delta = cos - transform.position.x;
        transform.Translate(new Vector3(delta, 0, 0));
    }
}

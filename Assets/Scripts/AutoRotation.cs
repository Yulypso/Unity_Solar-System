using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{

    public float m_rotSpeed = 10.0f;
    private float m_angle = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaAngle = Time.deltaTime * m_rotSpeed;
        m_angle += deltaAngle;

        Debug.Log(m_angle);

        this.transform.localRotation = Quaternion.Euler(0.0f, m_angle, 0.0f);
    }
}

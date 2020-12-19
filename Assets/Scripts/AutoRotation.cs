using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{

    public float m_rotSpeed = 10.0f;
    private float m_angle = 0.0f;
    public float z_angle = 0.0f;
    public float x_angle = 0.0f;
    public bool isPlanet = false; //to rotate arround the GameObject local Y axis 

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

        if (isPlanet)
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * m_rotSpeed);
        }
        else
        {
            this.transform.localRotation = Quaternion.Euler(x_angle, m_angle, z_angle);
        }
    }
}

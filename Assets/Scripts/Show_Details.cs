using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Details : MonoBehaviour
{
    public GameObject _text = null;
    private Camera _camera = null;

    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float planet_d = Vector3.Distance(_camera.transform.position, transform.position);

        //if (Input.GetKeyDown(KeyCode.Backspace))
        if(planet_d < 2)
        {
            _text.SetActive(true);
        }
        else
        {
            _text.SetActive(false);
        }

    }
}
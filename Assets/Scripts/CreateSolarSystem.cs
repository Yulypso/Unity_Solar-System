using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CreateSolarSystem : MonoBehaviour
{
    public GameObject _explanationBeforeInstanciation = null;
    public GameObject _prefab = null;
    public float _distance = 0.5f;
    public bool _created = false;
    // Update is called once per frame
    void Update()
    {
        //if(_prefab != null && !_created && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        if(_prefab != null && !_created && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(_prefab);
            Vector3 posCam = Camera.main.transform.position; // MainCamera tag set on AR Camera
            Vector3 dirCam = Camera.main.transform.forward;

            go.transform.position = posCam + dirCam * _distance;

            go.AddComponent<ARAnchor>(); // AR Anchor Manager set on AR Session Origin

            _created = true;

            if (_explanationBeforeInstanciation != null)
                _explanationBeforeInstanciation.SetActive(false);
        }
    }
}

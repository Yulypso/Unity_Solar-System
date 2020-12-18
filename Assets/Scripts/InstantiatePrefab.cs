using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{

    public GameObject _prefab = null;
    public Transform _parent = null;
    public Vector3 _position = Vector3.zero;

    private GameObject _instantiatedObject = null;

    public GameObject instantiatedObject
    {
        get { return _instantiatedObject; }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (_prefab == null)
            return;


        _instantiatedObject = Instantiate(_prefab, _parent);
        _instantiatedObject.transform.localPosition = _position;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

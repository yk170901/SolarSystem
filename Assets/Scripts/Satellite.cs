using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    private GameObject _parent;
    [SerializeField] private float _distance;
    [SerializeField] private float _relativeSize;
    [SerializeField] private float _oribitalSpeed;
    [SerializeField] private float _rotationalSpeed;


    void Start()
    {
        _parent = transform.parent.gameObject;
        transform.localScale = _parent.transform.localScale * _relativeSize;
        transform.position = new Vector3(_distance + _parent.transform.position.x, _parent.transform.position.y, 0f);
    }

    void Update()
    {
        transform.RotateAround(_parent.transform.position, Vector3.up, _oribitalSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, _rotationalSpeed * Time.deltaTime);
    }
}

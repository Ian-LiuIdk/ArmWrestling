using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControll : MonoBehaviour
{

    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;


    // Update is called once per frame
    void Update()
    {
        // P1
        if (Input.GetKeyDown(KeyCode.D))
            _rotation = Vector3.back;

        // P2
        else if (Input.GetKeyDown(KeyCode.A))
            _rotation = Vector3.forward;

        else
            _rotation = Vector3.zero;

        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
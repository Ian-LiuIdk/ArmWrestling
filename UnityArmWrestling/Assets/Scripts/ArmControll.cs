using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmControll : MonoBehaviour
{

    public static ArmControll instance;

    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    static public bool canMove = false;

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            // P1 controll
            if (Input.GetKeyDown(KeyCode.L))
                _rotation = Vector3.back;

            // P2 controll
            else if (Input.GetKeyDown(KeyCode.A))
                _rotation = Vector3.forward;

            else
                _rotation = Vector3.zero;

        }
        else if (canMove == false)
        {
            _rotation = Vector3.zero;
        }
        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
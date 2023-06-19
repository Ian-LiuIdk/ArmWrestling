using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationScript : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position , Vector3.up , 50 * Time.deltaTime);
    }
}

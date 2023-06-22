using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurningScript : MonoBehaviour
{
    public Transform Target;
    public float TurnSpeed = .01f;
    Quaternion rotGoal;
    Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        // turning speed of camera
        direction = (Target.position - transform.position).normalized;
        rotGoal = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotGoal,TurnSpeed);
    }
}

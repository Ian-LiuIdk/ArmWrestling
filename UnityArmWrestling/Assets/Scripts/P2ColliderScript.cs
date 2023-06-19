using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2ColliderScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P2arm")
        {
            print("P2 collided");
            GameController.Instance.TransitionP1Win();
        }
    }
}

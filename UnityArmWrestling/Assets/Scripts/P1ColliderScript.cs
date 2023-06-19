using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1ColliderScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P1arm")
        {
            print("P1 colided");
            GameController.Instance.TransitionP2Win();
        }
    }
}

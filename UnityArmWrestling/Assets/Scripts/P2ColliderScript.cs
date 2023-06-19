using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P2ColliderScript : MonoBehaviour
{
    static public bool P2lose = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P2arm")
        {
            P2lose = true;
            print("P2 collided");
            ArmControll.canMove = false;
            GameController.Instance.TransitionP1Win();
        }
    }
}

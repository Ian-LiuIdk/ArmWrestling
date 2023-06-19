using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1ColliderScript : MonoBehaviour
{
    static public bool P1lose = false;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "P1arm")
        {
            P1lose = true;
            print("P1 colided");
            ArmControll.canMove = false;
            GameController.Instance.TransitionP2Win();
        }
    }
}

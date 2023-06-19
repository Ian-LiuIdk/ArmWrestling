using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    
    public void TransitionP2Win()
    {
        SceneManager.LoadScene("P2WinScene");
    }
    public void TransitionP1Win()
    {
        SceneManager.LoadScene("P1WinScene");
    }
}

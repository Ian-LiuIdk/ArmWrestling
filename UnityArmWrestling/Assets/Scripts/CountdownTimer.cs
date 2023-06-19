using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public GameObject PlayerKeyPanel;
    public TextMeshProUGUI countdownDisplay;
    public int countdownTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        ArmControll.canMove = false;
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisplay.text = "GO";
        countdownDisplay.color = new Color32(0, 255, 15, 255);
        ArmControll.canMove = true;
        PlayerKeyPanel.SetActive(false);
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);

    }
}

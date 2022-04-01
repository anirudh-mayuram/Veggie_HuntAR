using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float timeValue1 = 90;
    public float timeValue2 = 60;
    public float timeValue3 = 45;
    public float timeVal = 90;
    public Text timeText;
    settings st = new settings();

    private void difficultySetter(int a)
    {
        if (a == 1)
        {
            timeVal = 90;
        }
        else if(a == 2)
        {
            timeVal = 60;
        }
        else if(a == 3)
        {
            timeVal = 45;
        }
    }

    void Start()
    {
        difficultySetter(st.difficulty);
    }
    void Update()
    {
        if (timeVal > 1)
        {
            timeVal -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("gameOver");
            timeVal = 0;
        }

        DisplayTime(timeVal);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}

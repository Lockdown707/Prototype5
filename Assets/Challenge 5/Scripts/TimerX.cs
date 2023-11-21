using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimerX : MonoBehaviour
{
    public float timeLeft;
    public int seconds = 60;
    public bool timerOn = false;
    public TextMeshProUGUI timerText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
        }
    }

    private void UpdateTimer(float currentTime)
    {
        timerText.text = "Time: " + timeLeft;
    }

    public void StartTimer()
    {
    timerOn = true;
    }
}

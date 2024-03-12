using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    Slider slTimer;
    private float systemTime = 300.0f;
    public float playTime;
    private float itemTime = 30.0f;

    void Start()
    {
        playTime = systemTime;
        slTimer = GetComponent<Slider>();
        slTimer.maxValue = playTime;
        slTimer.value = playTime;
    }

    void Update()
    {
        if (slTimer.value > 0.0f)
        {
            slTimer.value -= Time.deltaTime;
        }
        else
        {
            Debug.Log("게임오버");
        }
    }

    public void TimeItem()
    {
        slTimer.value += itemTime;
    }
}
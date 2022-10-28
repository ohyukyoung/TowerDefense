using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Timer : MonoBehaviour
{
    //public GameObject Button1;
    bool timerActive = false;
    public static float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    public GameObject NextRoundButton;

    private void Start()
    {
        currentTime = startMinutes * 60;
        StartTimer();
       
    }

    private void Update()
    {   
        if (timerActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
            if (currentTime <= 0)
            {
                if (Variables.Round == 3)
                {
                    Variables.Mission3Complete = true;                    
                    
                }
                else 
                {
                     timerActive = false; //�ʰ� ���̳ʽ� �ȵǵ��� ����
                      NextRoundButton.SetActive(true);
                    Variables.Enemy1StartHealth = 8;
                    Variables.Enemy1StartHealth =6;
                }
            }
 
        
        }
       
        TimeSpan time = TimeSpan.FromSeconds(currentTime); //��--> �� ��ȯ
        if (time.Seconds<10)
            currentTimeText.text = time.Minutes.ToString() + ":0" + time.Seconds.ToString();
        else
            currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    public void StartTimer()
    {
        timerActive = true;
    }

    public float GetCurrTime()
    {
        return currentTime;
    }

   
    
}

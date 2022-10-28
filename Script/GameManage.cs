using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManage : MonoBehaviour
{
    private float currTime;
    private void Start()
    {
        Variables.Enemy1StartHealth = 6;
        Variables.Enemy2StartHealth = 8;
    }
    void Update()
    {
        currTime += Time.deltaTime;

        if (Variables.Coins > 2300&&(!Variables.Mission4Complete))
        {
            Variables.Mission4Complete = true;
            print("업적 4가 클리어되었습니다");
        }

        if (currTime > 25) 
        {
            IncreasetStartHealth();
            currTime = 0;
           
        }
    }
    public void Round1()
    {
        SceneManager.LoadScene("Round1");
        Variables.Round = 1;
        Variables.Coins = 1500;
    }
    public void Round2(){
        SceneManager.LoadScene("Round2");
        Variables.Mission1Complete = true;
        Variables.Round = 2;
        Variables.Coins += 700;
    }
    public void Round3(){
        SceneManager.LoadScene("Round3");
        Variables.Mission2Complete = true;
        Variables.Round = 3;
        Variables.Coins += 1000;
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Achievement()
    {
        SceneManager.LoadScene("Achievement");
    }

    public void Tutorial_story()
    {
        SceneManager.LoadScene("Tutorial_story");
    }

    public void Tutorial_1()
    {
        SceneManager.LoadScene("Tutorial_1");
    }

    public void Tutorial_2()
    {
        SceneManager.LoadScene("Tutorial_2");
    }


    private void IncreasetStartHealth()
    {
        Variables.Enemy1StartHealth += 4;
        Variables.Enemy2StartHealth += 4;
        //print("Increased");
    }
}

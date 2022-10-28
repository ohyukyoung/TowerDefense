using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject Panel, GameClear, suryoung, Retry, MainMenu, TextS, Text2;
    [SerializeField] float playTime=30f;
    public AudioSource AllClear;
    private bool IsFirst = true;
    public GameObject tipText;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        EndTime();
    }

    void EndTime(){
        if(Timer.currentTime <= 0){
            Time.timeScale = 0;
            Panel.gameObject.SetActive(true);
            GameClear.gameObject.SetActive(true);
            suryoung.gameObject.SetActive(true);
            Retry.gameObject.SetActive(true);
            MainMenu.gameObject.SetActive(true);
            TextS.gameObject.SetActive(true);
            Text2.gameObject.SetActive(true);
            tipText.SetActive(false);
            if (IsFirst) //�ѹ��� ����� ���
            {
                AllClear.Play();
                IsFirst = false;
            }
        }
    }

    public void restartGame(){
        Panel.gameObject.SetActive(false);
        GameClear.gameObject.SetActive(false);
        suryoung.gameObject.SetActive(false);
        Retry.gameObject.SetActive(false);
        MainMenu.gameObject.SetActive(false);
        TextS.gameObject.SetActive(false);
        Text2.gameObject.SetActive(false);
        tipText.SetActive(true);
        Time.timeScale = 1;
        Timer.currentTime = playTime;
        SceneManager.LoadScene("Round3");
    }
}

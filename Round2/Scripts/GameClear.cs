using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameClear : MonoBehaviour
{
    [SerializeField] GameObject Panel, Round, Next, Text,Text1;
    [SerializeField] float playTime=30f;
    // Start is called before the first frame update
    private bool IsFirst = true;
    public AudioSource Clear;
    public GameObject TipText;
    // Update is called once per frame
    void Update()
    {
        EndTime();
    }

    void EndTime(){
        if(Timer.currentTime <= 0){
            Time.timeScale = 0;
            Panel.gameObject.SetActive(true);
            Round.gameObject.SetActive(true);
            Next.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);
            Text1.gameObject.SetActive(true);
            TipText.SetActive(false);
            if (IsFirst)
            {
                Clear.Play();
                IsFirst = false;
            }
        }
    }

    public void nextGame(){
        Panel.gameObject.SetActive(false);
        Round.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);
        Text1.gameObject.SetActive(false);
        TipText.SetActive(true);
        Time.timeScale = 1;
        Timer.currentTime = playTime;
        SceneManager.LoadScene("Round3");
    }
}

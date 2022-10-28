using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioScript : MonoBehaviour
{   
    private AudioSource audioSource;
    private GameObject[] musics;
    [SerializeField] GameObject BackGroundMusic;

    private void Awake(){
        musics = GameObject.FindGameObjectsWithTag("Music");

        if(musics.Length == 1){
            DontDestroyOnLoad(transform.gameObject);
        }
        
        else
        {
            Destroy(this.gameObject);
            
        }
        audioSource = GetComponent<AudioSource>();

    }
    void Update(){
        QuitMusic();
    }
    
    public void QuitMusic(){
        if(SceneManager.GetActiveScene().name == "Round1"){
            BackGroundMusic.gameObject.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().name == "MainMenu"){
            BackGroundMusic.gameObject.SetActive(false);

        }
    }

    public void PlayMusic(){
        if(audioSource.isPlaying) return;
        audioSource.Play();
    }

    public void StopMusic(){
        audioSource.Stop();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Awake(){
         PlayerPrefs.SetInt("CarChoice", 1);
    }

    public void PlayGame(){
        if (PlayerPrefs.GetInt("NightMode") == 0)
        {
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            SceneManager.LoadScene("GameSceneNight");
        }
    }

    public void QuitGame(){
        //Debug.Log("Quit");
        Application.Quit();
    }
}

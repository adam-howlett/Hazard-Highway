using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverState : MonoBehaviour
{
    public Text TimerText;
    public Timer timer;
    public Image img;
    public Text txt;
    private bool isgameover;
    public bool ispaused; 
    public GameObject GameOverImage;
    public GameObject GameOverText;
    public GameObject PauseText;
    public AudioSource deathAudio;


    //function below is called on a game over state, and the image and text constituting the Game Over Screen Appear
    //The other lines are to do with calling the Time spent in the game and displaying that as a score along with the game over screen;
    public void GameOver()
    {
        if (isgameover == false)
        {
            deathAudio.Play();
            Timer timer = TimerText.GetComponent("Timer") as Timer;
            GameOverImage.SetActive(true);
            GameOverText.SetActive(true);
            img.enabled = true;
            txt.enabled = true;
            txt.alignment = TextAnchor.MiddleCenter;
            txt.text = "Game Over! \nTime Lasted:  " + timer.timeScore.ToString() + "\n Press Space to Restart" + "\n Press Enter to return to Main Menu";
            Time.timeScale = 0;
            isgameover = true;
        }
        
    }

    // Start is called before the first frame update
    //Hides the Game over Text/Image until game over state is achieved (above)
    void Start()
    {
        Screen.brightness = -10f;
        ispaused = false;
        img.enabled = false;
        txt.enabled = false;
        GameOverImage.SetActive(false);
        GameOverText.SetActive(false);
        PauseText.SetActive(false);
    }


    // Update is called once per frame
    // When the space button is pressed at on a Game Over Screen, the game restarts, as does the timer.
    void Update()
    {
        if (isgameover && Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            if (PlayerPrefs.GetInt("NightMode") == 0)
            {
                SceneManager.LoadScene("GameScene");
            }
            else { SceneManager.LoadScene("GameSceneNight"); }
            
        }
        if (isgameover && Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MenuScene");
        }

        if (ispaused && isgameover == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ispaused = false;
                PauseText.SetActive(false);
                Time.timeScale = 1;
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                ispaused = false;
                Time.timeScale = 1;
                SceneManager.LoadScene("MenuScene");
            }
        }
        else {
            if (ispaused == false && isgameover == false && Input.GetKeyDown(KeyCode.Space))
            {
                PauseText.SetActive(true); ;
                Time.timeScale = 0;
                ispaused = true;
            }
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiobg : MonoBehaviour
{
    public AudioSource source;
    public bool isSoundOn;

    public void soundButtonPressed()
    {
        if (isSoundOn)
        {
            AudioListener.volume = 0;
            isSoundOn = false;
            
        }
        else
        {
            isSoundOn = true;
            AudioListener.volume = 1;
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        isSoundOn = false;
        AudioListener.volume = 0;
        source.Play();


    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}

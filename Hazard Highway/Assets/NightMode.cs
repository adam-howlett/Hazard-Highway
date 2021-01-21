using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NightMode : MonoBehaviour
{
    public TextMeshProUGUI text;
    public void NightModeSelected()
    {
        
        if(PlayerPrefs.GetInt("NightMode") == 0){
            PlayerPrefs.SetInt("NightMode",1);
            text.text = "NIGHT MODE: ON";
        } else { PlayerPrefs.SetInt("NightMode", 0);
            text.text = "NIGHT MODE: OFF";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("NightMode", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

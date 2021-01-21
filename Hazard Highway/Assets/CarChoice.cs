using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public void car1Selected(){
        PlayerPrefs.SetInt("CarChoice", 1);
    }

    public void car2Selected(){
        PlayerPrefs.SetInt("CarChoice", 2);
    }

      public void car3Selected(){
        PlayerPrefs.SetInt("CarChoice", 3);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text mtext;
    public double timeScore;
    public double startTime;

    // Start is called before the first frame update (& on every scene reset here - so startTime variable is used to stop the timer counting through each Game over State)
    void Start()
    {
         startTime = System.Math.Floor(Time.time);
    }

    // Update is called once per frame - Updates the Timer from the instance of the scene starting, dispays the result in the text
    void Update()
    {
        timeScore = System.Math.Floor(Time.time) - startTime;
        mtext.text = "Time: " + timeScore.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarLights : MonoBehaviour
{
    public Light light1, light2;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("NightMode") == 0)
        {
            light1.intensity = 0;
            light2.intensity = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

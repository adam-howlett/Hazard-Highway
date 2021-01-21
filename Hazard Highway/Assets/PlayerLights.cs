using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLights : MonoBehaviour
{
    public Light light1, light2;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("CarChoice") == 3)
        {
            light1.transform.position = new Vector3(light1.transform.position[0] + 0.35f, light1.transform.position[1], light1.transform.position[2]);
            light2.transform.position = new Vector3(light2.transform.position[0] + 0.35f, light2.transform.position[1], light2.transform.position[2]);
        }
        if (PlayerPrefs.GetInt("CarChoice") == 1)
        {
            light1.transform.position = new Vector3(light1.transform.position[0] + 0.12f, light1.transform.position[1], light1.transform.position[2]);
            light2.transform.position = new Vector3(light2.transform.position[0] + 0.12f, light2.transform.position[1], light2.transform.position[2]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCar : MonoBehaviour
{

    public Sprite CarChoice1;
    public Sprite CarChoice2;
    public Sprite CarChoice3;
    public PlayerMovement movement;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("CarChoice is " + PlayerPrefs.GetInt("CarChoice"));
        if(PlayerPrefs.GetInt("CarChoice") == 2){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CarChoice2;
            movement.maxSpeed = 15f;
            movement.acceleration = 3f;
        } else if(PlayerPrefs.GetInt("CarChoice") == 3){
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CarChoice3;
            movement.maxSpeed = 5f;
            movement.acceleration = 0.5f;
        } else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = CarChoice1;
            movement.maxSpeed = 10f;
            movement.acceleration = 1f;
        }

        
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
     //Debug.Log("CarChoice is " + PlayerPrefs.GetInt("CarChoice"));   
    }
}

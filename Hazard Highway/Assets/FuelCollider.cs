using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelCollider : MonoBehaviour
{
    public FuelCounter counter;
    public AudioSource fuelAudio;
    public AudioClip clip;


    //When the car interacts with the fuel pickup, the object is destroyed and 50 is added to the fuel counter (see FuelCounter Script)
    void OnTriggerEnter2D(Collider2D other)
    {
        fuelAudio.Play();
        transform.position = Vector3.one * 9999f;
        Destroy(gameObject, clip.length);
        //Debug.Log("Destroyed");
        counter.FuelPickup();

    }

}

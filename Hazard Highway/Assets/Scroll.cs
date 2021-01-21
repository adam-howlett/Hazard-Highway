using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float RoadSpeed;
    //Ignore this for now, its behaviour is horrible and I haven't got a chance to fix it properly
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2((Time.deltaTime * RoadSpeed), 0);
        GetComponent<Renderer>().material.mainTextureOffset += offset;
    }
}
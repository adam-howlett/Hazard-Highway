using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    public GameObject background;
    public Scroll scroll;
    private float stayhere;
    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("Background");
        scroll = background.GetComponent<Scroll>();
        stayhere = transform.position[1];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position[0] - 1.5f*Time.deltaTime*(scroll.RoadSpeed), stayhere, transform.position[2]);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        if(transform.position[0] < -20)
        {
            Destroy(gameObject);
        }
    }
}

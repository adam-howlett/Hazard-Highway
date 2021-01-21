using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyCarMovement : MonoBehaviour
{


    private float carspeed;
    private float stayhere;
    private float changelanespeed;
    private int CameFrom;
    // Start is called before the first frame update
    void Start()
    {
        CameFrom = System.Math.Sign(transform.position[0]);
        carspeed = Random.Range(10f, 20f);
        stayhere = transform.position[1];
    }

    void OnTriggerEnter2D(Collider2D other)
    {





            if (other.gameObject.name != "car")
            {
                if (System.Math.Abs(transform.position[1]) == 2)
                {
                    changelanespeed = -System.Math.Sign(transform.position[1]) * 15;
                    transform.rotation = Quaternion.Euler(0, 0, 90 + System.Math.Sign(transform.position[1])*20);

                }
                else
                {
                    if (System.Math.Abs(transform.position[1]) == 0 )
                    {
                        int movewhere = Random.Range(1, 3);
                        if (movewhere == 1)
                        {
                            changelanespeed = -15f;
                            transform.rotation = Quaternion.Euler(0, 0, 110);


                        }
                        else
                        {
                            changelanespeed = 15f;
                            transform.rotation = Quaternion.Euler(0, 0, 70);

                        }

                    }
                }   
            }
    

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(changelanespeed);
        transform.position = new Vector3(transform.position[0] - Time.deltaTime*carspeed, transform.position[1] + Time.deltaTime*changelanespeed, transform.position[2]);

        if (System.Math.Abs(transform.position[1]) > 2)
        {
            //Debug.Log("Here");
            transform.position = new Vector3(transform.position[0], 2 * System.Math.Sign(transform.position[1]), transform.position[2]);
            changelanespeed = 0;
            transform.rotation = Quaternion.Euler(0, 0, 90);
            CameFrom = System.Math.Sign(transform.position[1]);
        }

        if (System.Math.Abs(transform.position[1]) < 0.1 && CameFrom != 0)
        {
            changelanespeed = 0;
            transform.rotation = Quaternion.Euler(0, 0, 90);
            CameFrom = 0;
        }


        if (transform.position[0] < -20)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject car1, car2, car3, car4;
    private float spawnRate;
    private float nextSpawn = 0f;
    private int wheretospawn;
    private int whichCar;
    private Vector3 x;
    public FuelSpawn fuelspawn;
    public bool canspawntop, canspawnmiddle, canspawnbottom;
    // Start is called before the first frame update
    void Start()
    {
        canspawnbottom = true; canspawnmiddle = true; canspawntop = true;
        spawnRate = Random.Range(2, 4);
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            canspawnmiddle = true; canspawntop = true; canspawnbottom = true;
            wheretospawn = Random.Range(1, 4);
            switch (wheretospawn)
            {
                case 1:
                    if (fuelspawn.canspawnmiddle)
                    {
                        x = new Vector3(30f, 0f, 0f);
                        canspawnmiddle = false;
                    }
                    else { x = new Vector3(-20f, 0f, 0f); }
                    break;
                case 2:
                    if (fuelspawn.canspawntop)
                    {
                        x = new Vector3(30f, 2f, 0f);
                        canspawntop = false;
                    }
                    else { x = new Vector3(-20f, 0f, 0f); }
                    break;
                case 3:
                    if (fuelspawn.canspawnbottom)
                    {
                        //Debug.Log("car");
                        x = new Vector3(30f, -2f, 0f);
                        canspawnbottom = false;
                    }
                    else { x = new Vector3(-20f, 0f, 0f); }
                    break;
            }

            whichCar = Random.Range(1, 5);
            switch (whichCar)
            {
                case 1:
                    Instantiate(car1, x, Quaternion.Euler(0, 0, 90));
                    break;
                case 2:
                    Instantiate(car2, x, Quaternion.Euler(0, 0, 90));
                    break;
                case 3:
                    Instantiate(car3, x, Quaternion.Euler(0, 0, 90));
                    break;
                case 4:
                    Instantiate(car4, x, Quaternion.Euler(0, 0, 90));
                    break;

            }
            spawnRate = Random.Range(2, 4);
            nextSpawn = Time.time + spawnRate;
        }
    }
}

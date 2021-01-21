using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelSpawn : MonoBehaviour
{
    public GameObject Fuel;
    public RockSpawn rockspawn;
    private float spawnRate;
    private float nextSpawn = 0f;
    private int wheretospawn;
    public bool canspawntop, canspawnmiddle, canspawnbottom;
    private Vector3 x;
    private float timespawnedago;
    // Start is called before the first frame update
    void Start()
    {
        canspawnbottom = true; canspawnmiddle = true; canspawntop = true;
        spawnRate = Random.Range(10, 20);
        timespawnedago = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timespawnedago > 2f)
        {
            canspawnbottom = true; canspawnmiddle = true; canspawntop = true;
        }
        if (Time.time > nextSpawn)
        {
            canspawnbottom = true; canspawnmiddle = true; canspawntop = true;
            wheretospawn = Random.Range(1, 4);
            switch (wheretospawn)
            {
                case 1:
                    if (rockspawn.canspawnmiddle) { x = new Vector3(15f, 0f, 0f);
                        canspawnmiddle = false;
                    }
                    else {x = new Vector3(-15f, 0f, 0f); }
                    break;
                case 2:
                    if (rockspawn.canspawntop) { x = new Vector3(15f, 2f, 0f);
                        canspawntop = false;
                    }
                    else { x = new Vector3(-15f, 0f, 0f); }
                    break;
                case 3:
                    if (rockspawn.canspawnbottom) {
                       // Debug.Log("Fuel");
                        x = new Vector3(15f, -2f, 0f);
                        canspawnbottom = false;
                    }
                    else { x = new Vector3(-15f, 0f, 0f); }
                    break;
            }
            
            spawnRate = Random.Range(10, 15);
            Instantiate(Fuel, x, Quaternion.Euler(0, 0, 0));
            nextSpawn = Time.time + spawnRate;
        }
    }
}

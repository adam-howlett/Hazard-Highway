using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treemoving : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 4f;
    public float width = 30f;
   
  

    // Update is called once per frame
    void Update()
    {
        foreach (Transform trans in transform)
        {
            Vector3 v = trans.position;
            v.x -= speed * Time.deltaTime;
            if (v.x < -width)
            {
                v.x += width * 2;
             
            }
            trans.position = v;
        }
    }
}

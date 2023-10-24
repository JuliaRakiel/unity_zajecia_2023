using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float distancePerSecond;

    void Update()
    {
        transform.Translate(distancePerSecond * Time.deltaTime, 0, 0);
        if (transform.position.x > 10f || transform.position.x < -10f)
        {
            distancePerSecond = -distancePerSecond;
        }
      
       

    }
}

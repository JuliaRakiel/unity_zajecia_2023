using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad2 : MonoBehaviour
{
    public float speed = 5.0f; // prêdkoœæ

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0); // przesuniêcie obiektu w osi x
        if (transform.position.x > 10f || transform.position.x < 0f) // jeœli  0>x>10 speed jest zmieniany na wartoœæ przeciwn¹
        {
            speed = -speed;
        }
    }
}

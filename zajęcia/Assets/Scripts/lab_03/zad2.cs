using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad2 : MonoBehaviour
{
    public float speed = 5.0f; // pr�dko��

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0); // przesuni�cie obiektu w osi x
        if (transform.position.x > 10f || transform.position.x < 0f) // je�li  0>x>10 speed jest zmieniany na warto�� przeciwn�
        {
            speed = -speed;
        }
    }
}

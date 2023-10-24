using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3 : MonoBehaviour
{
    public float speed = 5.0f; // prêdkoœæ
    private Vector3[] corners; // wierzcho³ki
    private int currentCorner = 0; // index w tablicy nastêpnego wierzcho³ka (togo, do którego chcemy dotrzeæ)

    void Start()
    {
        // przy uruchomieniu gry tworzymy tablicê wekrorów (wierzcho³ków), w których bêdzie wykonywany obrót
        corners = new Vector3[4];
        corners[0] = transform.position + Vector3.right * 10;
        corners[1] = corners[0] + Vector3.back * 10;
        corners[2] = corners[1] + Vector3.left * 10;
        corners[3] = transform.position;
    }

    void Update()
    {
        // przejœcie z obecnego wierzcho³ka do nastêpnegp
        transform.position = Vector3.MoveTowards(transform.position, corners[currentCorner], speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, corners[currentCorner]) < 0.001f)
        {
            transform.Rotate(Vector3.up, 90.0f); // obrót o 90 stopni

            currentCorner = (currentCorner + 1) % 4; // zmiana wierzcho³ka
        }
    }
}

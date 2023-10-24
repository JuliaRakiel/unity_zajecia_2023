using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3 : MonoBehaviour
{
    public float speed = 5.0f; // pr�dko��
    private Vector3[] corners; // wierzcho�ki
    private int currentCorner = 0; // index w tablicy nast�pnego wierzcho�ka (togo, do kt�rego chcemy dotrze�)

    void Start()
    {
        // przy uruchomieniu gry tworzymy tablic� wekror�w (wierzcho�k�w), w kt�rych b�dzie wykonywany obr�t
        corners = new Vector3[4];
        corners[0] = transform.position + Vector3.right * 10;
        corners[1] = corners[0] + Vector3.back * 10;
        corners[2] = corners[1] + Vector3.left * 10;
        corners[3] = transform.position;
    }

    void Update()
    {
        // przej�cie z obecnego wierzcho�ka do nast�pnegp
        transform.position = Vector3.MoveTowards(transform.position, corners[currentCorner], speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, corners[currentCorner]) < 0.001f)
        {
            transform.Rotate(Vector3.up, 90.0f); // obr�t o 90 stopni

            currentCorner = (currentCorner + 1) % 4; // zmiana wierzcho�ka
        }
    }
}

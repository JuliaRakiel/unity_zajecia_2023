using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad5 : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfCubes = 10;
    public float planeSize = 100f; // 1 jednostka miary obiektu plane jest równa 10 jednostkom miary obiektu cube

    void Start()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            // wybór pozycji dla nowej kostki, losowy x i z
            Vector3 position = new Vector3(Random.Range(-planeSize / 2f, planeSize / 2f), 0.5f, Random.Range(-planeSize / 2f, planeSize / 2f));
            Instantiate(prefab, position, Quaternion.identity); 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            // jeœli wykrywana jest kolizja, to jest generowany nowy wektor i ustawiany jako nowa pozycja
            Vector3 newPosition = new Vector3(Random.Range(-planeSize / 2f, planeSize / 2f), 0.5f, Random.Range(-planeSize / 2f, planeSize / 2f));
            collision.gameObject.transform.position = newPosition;
        }
    }
}
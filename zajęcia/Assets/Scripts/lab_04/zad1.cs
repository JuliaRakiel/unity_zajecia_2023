using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    public GameObject block;
    public int numberOfObjects = 10;
    private GameObject platform;
    public Material[] availableMaterials;

    void Start()
    {

        platform = this.gameObject;

        List<float> posXList = new List<float>();
        List<float> posZList = new List<float>();

       

        for (int i = 0; i < numberOfObjects; i++)
        {
            float randomX = Random.Range(-platform.transform.localScale.x * 5, platform.transform.localScale.x * 5); 
            float randomZ = Random.Range(-platform.transform.localScale.z * 5, platform.transform.localScale.z * 5);
            // powinno byæ "/ 2" zamiast "* 5", natomiast jednostka miary plane jest inna ni¿ cube (jest 10 razy wiêksza),
            // ¿eby obiekty mog³y siê pojawiaæ na ca³ym plane i nie zapisywaæ tego w sposób "/ 2 * 10" zapisa³am po prostu "* 5"


            posXList.Add(randomX);
            posZList.Add(randomZ);
        }

        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt(posXList, posZList));
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt(List<float> posXList, List<float> posZList)
    {

        for (int i = 0; i < numberOfObjects; i++)
        {
            // Wybierz losowy materia³
            Material randomMaterial = availableMaterials[Random.Range(0, availableMaterials.Length)];

            Vector3 spawnPosition = new Vector3(
                platform.transform.position.x + posXList[i],
                platform.transform.position.y + 5,
                platform.transform.position.z + posZList[i]
            );

            // Wygeneruj obiekt z losowym materia³em
            GameObject newObject = Instantiate(block, spawnPosition, Quaternion.identity);
            newObject.GetComponent<Renderer>().material = randomMaterial;

            yield return new WaitForSeconds(delay);
        }

    }
}

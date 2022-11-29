using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{
    public Timer time;

    public GameObject[] spawners;
    public GameObject[] objects;

    float timeDelay;
    float objectGenerator;

    public void Awake()
    {
        objectGenerator = Random.Range(1, 3);

    }
    public void Start()
    {
        objects = new GameObject[1];
        spawners = new GameObject[5];

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i] = transform.GetChild(i).gameObject;
        }

        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }
        StartCoroutine(InstantiateObject());
    }

    IEnumerator InstantiateObject()
    {
        timeDelay = Random.Range(2f, 5f);
        yield return new WaitForSeconds(timeDelay);

        if (time.timeValue > 0)
        {
            int spawnerID = Random.Range(2, 6);
            int creatureID = Random.Range(0, objects.Length);

            Instantiate(objects[creatureID], spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
            StartCoroutine(InstantiateObject());
        }
    }
}

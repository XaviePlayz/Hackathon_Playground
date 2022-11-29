using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{
    public Timer time;

    public GameObject[] spawners;
    public GameObject cube;

    public TouchInput touch;

    float timeDelay;
    void Start()
    {
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        int spawnerID = Random.Range(0, 5);

        timeDelay = Random.Range(2f, 5f);
        yield return new WaitForSeconds(timeDelay);

        if (time.timeValue > 0)
        {
            Instantiate(cube, spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
            touch.cubes.Add(cube);

            StartCoroutine(Generate());
        }
    }
}

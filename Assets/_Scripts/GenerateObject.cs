using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{
    public Timer time;

    public GameObject[] spawners;
    public GameObject flowerPrefab;

    public TouchInput touch;

    float timeDelay;
    void Start()
    {
        for (int i = 0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
        }
    }

    public void Generate()
    {
        int spawnerID = Random.Range(0, 5);

        if (time.timeValue > 0)
        {
            Instantiate(flowerPrefab, spawners[spawnerID].transform.position, spawners[spawnerID].transform.rotation);
            touch.flowerObject = GameObject.FindGameObjectWithTag("collectibleToDestroy");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    public List<GameObject> cubes;
    public Animator animator;
    public int spawnedObjects;


    [Header("Scripts")]
    public ScoreManager scoremanager;
    public GenerateObject generator;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit))
                if (hit.collider.gameObject.tag == "collectibleToDestroy")
                {
                    animator.Play("1_Point");
                    Destroy(cubes[spawnedObjects]);
                    spawnedObjects++;
                    StartCoroutine(WaitTillAnimationComplete());
                }
        }
    }

    IEnumerator WaitTillAnimationComplete()
    {
        yield return new WaitForSeconds(0.5f);
        scoremanager.score += 1;
        generator.Generate();
        StopCoroutine(WaitTillAnimationComplete());
    }
}

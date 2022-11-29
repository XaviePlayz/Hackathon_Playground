using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    public GameObject cube;
    public Animator animator;


    [Header("Scripts")]
    public ScoreManager scoremanager;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if (Physics.Raycast(ray, out hit))
                if (hit.collider.gameObject.tag == "collectibleToDestroy")
                {
                    animator.SetTrigger("+1_Point");
                    Destroy(cube);
                    StartCoroutine(WaitTillAnimationComplete());
                }
        }
    }

    IEnumerator WaitTillAnimationComplete()
    {
        yield return new WaitForSeconds(0.5f);
        scoremanager.score += 1;
        StopCoroutine(WaitTillAnimationComplete());
    }
}

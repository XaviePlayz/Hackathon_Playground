using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class AR_Cursor : MonoBehaviour
{
    public GameObject cursor;
    public GameObject objectToPlace;
    public ARRaycastManager raycastManager;

    public bool useCursor = true;

    void Start()
    {
        cursor.SetActive(useCursor);
    }

    void Update()
    {
        if (useCursor)
        {
            UpdateCursor();
        }
    }

    void UpdateCursor() 
    {
        Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
    }
}

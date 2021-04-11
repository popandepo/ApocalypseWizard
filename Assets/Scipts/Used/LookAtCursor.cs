using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCursor : MonoBehaviour
{
    [SerializeField] private GameObject owner;

    private float rotationSpeed = 15f;

    private void Awake()
    {
        rotationSpeed = owner.GetComponent<Variables>().rotationSpeed;
    }


    void FixedUpdate()
    {
        Tools.TurnTowardsPoint(transform, Camera.main.ScreenToWorldPoint(Input.mousePosition), rotationSpeed);
    }

    
}
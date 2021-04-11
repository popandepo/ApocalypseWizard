using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject owner;
    [SerializeField] private GameObject target;
    //[SerializeField] private Rigidbody2D rigidbody;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    
    private void Update()
    {
        Tools.TurnTowardsPoint(transform, target.transform.position, rotationSpeed);
    }

    private void LateUpdate()
    {
        transform.position += transform.right.normalized * Time.deltaTime * movementSpeed;
    }
}
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private GameObject owner;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameObject target;

    private void Awake()
    {
        owner = gameObject;
    }

    private void Update()
    {
        Tools.TurnTowardsPoint(transform, target.transform.position, rotationSpeed);
    }

    private void LateUpdate()
    {
        transform.position += transform.right.normalized * Time.deltaTime * movementSpeed;
    }
}
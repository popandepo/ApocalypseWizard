using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    private GameObject owner;

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
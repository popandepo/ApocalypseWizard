using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 movement;

    private float movementSpeed;
    private GameObject owner;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        owner = gameObject;
        movementSpeed = owner.GetComponent<PlayerVariables>().movementSpeed;
        rigidBody = owner.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement.normalized * movementSpeed * Time.fixedDeltaTime);
    }
}
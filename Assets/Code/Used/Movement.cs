using UnityEngine;

public class Movement : MonoBehaviour
{
    private GameObject owner;

    private float movementSpeed;
    private Rigidbody2D rigidBody;

    Vector2 movement;

    private void Awake()
    {
        owner = gameObject;
        movementSpeed = owner.GetComponent<PlayerVariables>().movementSpeed;
        rigidBody = owner.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement.normalized * movementSpeed * Time.fixedDeltaTime);
    }
}
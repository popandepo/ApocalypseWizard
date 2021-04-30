using UnityEngine;

public class LookAtCursor : MonoBehaviour
{
    private GameObject owner;

    private float rotationSpeed = 15f;

    private void Awake()
    {
        owner = gameObject;
        rotationSpeed = owner.GetComponent<PlayerVariables>().rotationSpeed;
    }


    private void FixedUpdate()
    {
        Tools.TurnTowardsPoint(transform, Camera.main.ScreenToWorldPoint(Input.mousePosition), rotationSpeed);
    }
}
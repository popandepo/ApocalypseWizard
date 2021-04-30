using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    private void Awake()
    {
        Controller.allObjects.Add(gameObject);
    }

    private void LateUpdate()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.right.normalized * bulletSpeed;
        //transform.position += transform.right.normalized * Time.deltaTime * bulletSpeed;
    }
}
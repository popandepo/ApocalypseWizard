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
        transform.position += transform.right.normalized * Time.deltaTime * bulletSpeed;
    }
}

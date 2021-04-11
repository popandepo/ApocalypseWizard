using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] private GameObject owner;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject spawnObject;
    private Vector2 position;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            position = spawnObject.transform.transform.position;
            Instantiate(bullet, position, owner.transform.rotation);
        }
    }
}

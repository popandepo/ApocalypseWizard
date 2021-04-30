using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletHolder;
    [SerializeField] private BulletType bulletType = BulletType.Normal;
    [SerializeField] private GameObject normalBullet;
    private GameObject owner;

    private Vector2 position;
    [SerializeField] private GameObject spawnObject;

    private void Awake()
    {
        owner = gameObject;
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && bulletType != BulletType.End)
        {
            bulletType += 1;
            if (bulletType == BulletType.End) bulletType = BulletType.End - 1;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && bulletType != BulletType.Start)
        {
            bulletType -= 1;
            if (bulletType == BulletType.Start) bulletType = BulletType.Start + 1;
        }

        if (Input.GetMouseButtonDown(0))
        {
            position = spawnObject.transform.transform.position;
            switch (bulletType)
            {
                case BulletType.Normal:
                    GameObject blt = Instantiate(normalBullet, position, owner.transform.rotation);
                    blt.transform.parent = bulletHolder.transform;
                    break;
                case BulletType.Penetrating:
                    Debug.Log("penetrating bullet");
                    break;
                case BulletType.Homing:
                    Debug.Log("homing bullet");
                    break;
                case BulletType.Arcing:
                    Debug.Log("arcing bullet");
                    break;
            }
        }
    }
}
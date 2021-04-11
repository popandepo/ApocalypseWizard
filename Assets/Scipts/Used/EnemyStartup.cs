using UnityEngine;

public class EnemyStartup : MonoBehaviour
{
    [SerializeField] private GameObject owner;
    [SerializeField] private EnemyType enemyType;
    [SerializeField] private int Health;
    [SerializeField] private int Attack;

    private void Awake()
    {
        switch (enemyType)
        {
            case EnemyType.Test:
                break;
            case EnemyType.Fire:
                owner.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                break;
            case EnemyType.Water:
                owner.GetComponent<SpriteRenderer>().color = new Color(0, 0, 255);
                break;
            case EnemyType.Slime:
                owner.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
                break;
            default:
                break;
        }
    }
}

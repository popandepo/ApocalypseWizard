using UnityEngine;

public class EnemyStartup : MonoBehaviour
{
    [SerializeField] private int Attack;
    [SerializeField] private EnemyType enemyType;
    [SerializeField] private int Health;
    private GameObject owner;

    private void Awake()
    {
        owner = gameObject;
        Controller.allObjects.Add(gameObject);
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
        }
    }
}
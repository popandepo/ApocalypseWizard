using UnityEngine;

public class Variables : MonoBehaviour
{
    [SerializeField] public int health = 100;
    [SerializeField] public float movementSpeed = 30;
    [SerializeField] public float rotationSpeed = 15;

    [SerializeField] public Color wandShaftColor = new Color(109, 54, 0);
    [SerializeField] public Color wandTipColor = new Color(128, 0, 0);
}

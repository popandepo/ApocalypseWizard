using UnityEngine;

public class WandColor : MonoBehaviour
{
    [SerializeField] private GameObject owner;

    private Color shaftColor;
    private Color tipColor;

    private void Awake()
    {
        shaftColor = owner.GetComponent<PlayerVariables>().wandShaftColor;
        tipColor = owner.GetComponent<PlayerVariables>().wandTipColor;

        SpriteRenderer[] spriteRendererList = GetComponentsInChildren<SpriteRenderer>();
        foreach (var entry in spriteRendererList)
        {
            if (entry.gameObject.name.Contains("Shaft"))
            {
                entry.color = shaftColor;
            }
            if (entry.gameObject.name.Contains("Tip"))
            {
                entry.color = tipColor;
            }
        }
    }
}

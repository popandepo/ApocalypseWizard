using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandColor : MonoBehaviour
{
    [SerializeField] private Color shaftColor;
    [SerializeField] private Color tipColor;

    private void Awake()
    {
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

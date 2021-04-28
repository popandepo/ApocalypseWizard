using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static List<GameObject> allObjects = new List<GameObject>();

    private string debugText;

    private void Update()
    {
        string text = "";
        foreach (var obj in allObjects)
        {
            text += obj.name + "\n";
        }
        if (text != debugText)
        {
            Debug.Log(text);
            debugText = text;
        }
    }

}
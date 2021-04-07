using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void ButtonAct(ButtonEnum buttonType)
    {
        switch (buttonType)
        {
            case ButtonEnum.Start:
                Debug.Log("pressed");
                break;
            case ButtonEnum.Resume:
                break;
            case ButtonEnum.Quit:
                break;
            default:
                break;
        }
    }
}

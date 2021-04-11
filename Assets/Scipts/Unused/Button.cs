using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private ButtonEnum ButtonType;

    private void Start()
    {
        Debug.Log("start" + this.name);
    }
    private void OnMouseUpAsButton()
    {
        Debug.Log("button detected press");

        GameObject handler = GameObject.Find("ButtonHandler");
        ButtonHandler buttonScript = handler.GetComponent<ButtonHandler>();
        buttonScript.ButtonAct(ButtonType);
    }
}

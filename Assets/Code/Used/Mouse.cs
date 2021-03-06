using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] private readonly bool visibleMouse = true;

    private void Awake()
    {
        Cursor.visible = visibleMouse;
    }

    private void FixedUpdate()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
    }
}
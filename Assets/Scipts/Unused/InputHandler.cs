using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    //lmb
    public event EventHandler OnLMBPressed;
    public event EventHandler OnLMBHeld;
    public event EventHandler OnLMBReleased;

    //rmb
    public event EventHandler OnRMBPressed;
    public event EventHandler OnRMBHeld;
    public event EventHandler OnRMBReleased;

    //space
    public event EventHandler OnSpacePressed;
    public event EventHandler OnSpaceHeld;
    public event EventHandler OnSpaceReleased;

    //shift
    public event EventHandler OnLShiftPressed;
    public event EventHandler OnLShiftHeld;
    public event EventHandler OnLShiftReleased;

    //w
    public event EventHandler OnWPressed;
    public event EventHandler OnWHeld;
    public event EventHandler OnWReleased;

    //a
    public event EventHandler OnAPressed;
    public event EventHandler OnAHeld;
    public event EventHandler OnAReleased;

    //s
    public event EventHandler OnSPressed;
    public event EventHandler OnSHeld;
    public event EventHandler OnSReleased;

    //d
    public event EventHandler OnDPressed;
    public event EventHandler OnDHeld;
    public event EventHandler OnDReleased;


    private void Update()
    {
        //MOUSE

        //LEFT MOUSE BUTTON
        //pressed
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OnLMBPressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.Mouse0))
        {
            OnLMBHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            OnLMBReleased?.Invoke(this, EventArgs.Empty);
        }

        //RIGHT MOUSE BUTTON
        //pressed
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            OnRMBPressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.Mouse1))
        {
            OnRMBHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            OnRMBReleased?.Invoke(this, EventArgs.Empty);
        }

        //KEYBOARD

        //SPACE
        //pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.Space))
        {
            OnSpaceHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.Space))
        {
            OnSpaceReleased?.Invoke(this, EventArgs.Empty);
        }

        //LEFT SHIFT
        //pressed
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            OnLShiftPressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.LeftShift))
        {
            OnLShiftHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            OnLShiftReleased?.Invoke(this, EventArgs.Empty);
        }

        //WASD
        //W
        //pressed
        if (Input.GetKeyDown(KeyCode.W))
        {
            OnWPressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.W))
        {
            OnWHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.W))
        {
            OnWReleased?.Invoke(this, EventArgs.Empty);
        }

        //A
        //pressed
        if (Input.GetKeyDown(KeyCode.A))
        {
            OnAPressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.A))
        {
            OnAHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.A))
        {
            OnAReleased?.Invoke(this, EventArgs.Empty);
        }

        //S
        //pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            OnSPressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.S))
        {
            OnSHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.S))
        {
            OnSReleased?.Invoke(this, EventArgs.Empty);
        }

        //D
        //pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            OnDPressed?.Invoke(this, EventArgs.Empty);
        }
        //held
        if (Input.GetKey(KeyCode.D))
        {
            OnDHeld?.Invoke(this, EventArgs.Empty);
        }
        //released
        if (Input.GetKeyUp(KeyCode.D))
        {
            OnDReleased?.Invoke(this, EventArgs.Empty);
        }
    }
}

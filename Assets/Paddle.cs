using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Paddle : MonoBehaviour
{
    public float speed = 5f;
    public Key upKey;
    public Key downKey;

    void Update()
    {
        float move = 0;

        if (Keyboard.current[upKey].isPressed) move = 1;
        if (Keyboard.current[downKey].isPressed) move = -1;

        float posicionY = transform.position.y;
        float nuevaPosicionY = posicionY + move * speed * Time.deltaTime;

        if ((nuevaPosicionY < 5) && (nuevaPosicionY > -5))
        {
            transform.Translate(Vector2.up * move * speed * Time.deltaTime);
        }        
    }
}
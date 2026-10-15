using UnityEngine; 
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
        public float moveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;

        if (Keyboard.current.wKey.isPressed) direction.y  += 1;
        if (Keyboard.current.sKey.isPressed) direction.y  -= 1;
        if (Keyboard.current.aKey.isPressed) direction.x  -= 1;
        if (Keyboard.current.dKey.isPressed) direction.x  += 1;

        direction = direction.normalized;
             Vector3 isoDirection = new Vector3(
    direction.x - direction.y,
    (direction.x + direction.y) * 0.5f,
    0
);

transform.position += isoDirection.normalized * moveSpeed * Time.deltaTime;
    }
}

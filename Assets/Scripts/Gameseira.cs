using UnityEngine;
using UnityEngine.InputSystem;
public class ControlPlayer : MonoBehaviour
{
    private float speed = 5f;
    private float JumpForce = 5f;
    private Vector2 moveInput;
    private bool IsJumping;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
    }
    
    public void OnJump(InputValue value){
        IsJumping = value.isPressed;
        if(IsJumping){
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
        }
    }

    private void FixedUpdate(){
        rb.linearVelocity = new Vector2(moveInput.x*speed, rb.linearVelocity.y);
    }
}

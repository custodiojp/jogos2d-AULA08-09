using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float initialVelocity;
    public bool lookingRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (lookingRight)
        {                       //(1,0)
            rb.linearVelocity = Vector2.right * initialVelocity;
        }
        else
        {                       //(-1,0)
            rb.linearVelocity = Vector2.left * initialVelocity;
        }
    }
}

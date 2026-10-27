//codigo ORIGINAL

// using UnityEngine;

// public class EnemyController : MonoBehaviour
//{
//    public Transform position1;
//    public Transform position2;

//    public float velocity;

//    private bool seguindoPos1 = true;
//    private Rigidbody2D rb;
//    public float minimunDistance;
//    private float targetX;
//    void Start()
//    {
//        rb = gameObject.GetComponent<Rigidbody2D>();
//        targetX = position1.position.x;
//    }

//    void Update()
//    {
//        float personagemX = this.gameObject.transform.position.x;
//        float distance = Mathf.Abs(personagemX-targetX);



//        if (distance < minimunDistance)
//        {
//            if (seguindoPos1)
//            {
//                targetX = position2.position.x;
//            }
//            else
//            {
//                targetX = position1.position.x;
//            }

//            seguindoPos1 = !seguindoPos1;
//        }
//        if (personagemX > targetX)
//        {
//            rb.linearVelocity = new Vector2(-velocity,
//                                            rb.linearVelocity.y);
//        }
//        else
//        {
//            rb.linearVelocity = new Vector2(velocity,
//                                             rb.linearVelocity.y);
//        }
//    }
//}
//------------------------------------------------------------------------------------------------

//CODIGO COM IA
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform position1;
    public Transform position2;

    public float velocity;
    public float minimunDistance;

    private bool seguindoPos1 = true;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private float targetX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        targetX = position1.position.x;
    }

    void Update()
    {
        float personagemX = transform.position.x;
        float distance = Mathf.Abs(personagemX - targetX);

        // Verifica se chegou perto do destino
        if (distance < minimunDistance)
        {
            if (seguindoPos1)
            {
                targetX = position2.position.x;
            }
            else
            {
                targetX = position1.position.x;
            }

            seguindoPos1 = !seguindoPos1;
        }

        // Movimenta o inimigo no eixo X
        if (personagemX > targetX)
        {
            rb.linearVelocity = new Vector2(
                -velocity,
                rb.linearVelocity.y
            );
        }
        else
        {
            rb.linearVelocity = new Vector2(
                velocity,
                rb.linearVelocity.y
            );
        }

        // Vira o sprite de acordo com a direção do movimento
        if (rb.linearVelocity.x > 0.4f)
        {
            spriteRenderer.flipX = false;
        }
        else if (rb.linearVelocity.x < -0.4f)
        {
            spriteRenderer.flipX = true;
        }
    }
}

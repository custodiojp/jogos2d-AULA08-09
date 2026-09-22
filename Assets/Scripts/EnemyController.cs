// CODIGO ANTERIOR SEM IA
// 
// using UnityEngine;

// public class EnemyController : MonoBehaviour
// {
//     public Transform position1;
//     public Transform position2;

//     public float velocity;

//     private bool seguindoPos1 = true;
//     private Rigidbody2D rb;
//     void Start()
//     {
//         rb = gameObject.GetComponent<Rigidbody2D>();
//     }

//     void Update()
//     {
//         if(this.gameObject.transform.position.x>position1.position.x){
//             rb.linearVelocity = new Vector2(-velocity,
//                                             rb.linearVelocity.y);
//         }else{
//             rb.linearVelocity = new Vector2(velocity,
//                                              rb.linearVelocity.y);
//         }
//     }
// }
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform position1;
    public Transform position2;
    public float velocity;

    private bool seguindoPos1 = true;
    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Define o alvo atual com base na variável seguindoPos1
        Transform alvoAtual = seguindoPos1 ? position1 : position2;

        // Move o inimigo em direção ao alvo atual
        if (this.gameObject.transform.position.x > alvoAtual.position.x)
        {
            rb.linearVelocity = new Vector2(-velocity, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(velocity, rb.linearVelocity.y);
        }

        // Verifica se o inimigo chegou perto o suficiente do alvo para mudar de direção
        if (Mathf.Abs(this.gameObject.transform.position.x - alvoAtual.position.x) < 0.2f)
        {
            seguindoPos1 = !seguindoPos1;
        }
    }
}

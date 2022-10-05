using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] private float upforce = 100f;

    private bool isDead;
    private Rigidbody2D playerRb;
    private Animator playerAnimator; 

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();

    }

    void Update()
    {
        //metodo para que al momento de dar clic izq salte y tenga siempre el mismo salto
        if (Input.GetMouseButton(0) && !isDead)
        {
            Flap();
        }
    }
    private void Flap()
    {
        playerRb.velocity = Vector2.zero;
        playerRb.AddForce(Vector2.up * upforce );
        playerAnimator.SetTrigger("Flap");
    }

    private void OnCollisionEnter2D()
    {
        isDead = true;
        playerAnimator.SetTrigger("Die");
        GameManager.Instance.GameOver();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float Speed;
    public float jumpForce;

    public bool isJumping;
    public bool doubleJump;

    private Rigidbody2D rig;

    // Start quando inicia o 1° frame apenas UMA VEZ
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // chamado a cada frame
    void Update()
    {
        move();
        jump();
    }

    void move()
    {
        //variavel (movement) recebe novo vector com as posições do input 0, 0
        //Horizontal - direciona os botões dentro da engine, atribuindo o valor
        //multiplicação para ter um valor de velocidade

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); 
        transform.position += movement * Time.deltaTime * Speed;
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                doubleJump = true;
            }
            else
            {
                if(doubleJump)
                {
                    rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
          
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isJumping = true;

        }
    }


}

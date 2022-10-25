using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float Speed;
    public float jumpForce; 
    private Rigidbody2D rig;

    // Start quando inicia o 1� frame apenas UMA VEZ
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
        //variavel (movement) recebe novo vector com as posi��es do input 0, 0
        //Horizontal - direciona os bot�es dentro da engine, atribuindo o valor
        //multiplica��o para ter um valor de velocidade

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); 
        transform.position += movement * Time.deltaTime * Speed;
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}

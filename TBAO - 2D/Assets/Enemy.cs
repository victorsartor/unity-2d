using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxVida = 100;
    int currentVida;

    void Start()
    {
        currentVida = maxVida;
    }

    public void TakeDamage(int damage)
    {
        currentVida -= damage;

        //play hurt animation
        animator.SetTrigger("Hurt");

        if(currentVida <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy MORREU");

        //die animation
        animator.SetBool("Die", true);

        //disable the enemy
        GetComponent<CircleCollider2D>().enabled = false;
        this.enabled = false;

        //GetComponentInChildren<SpriteRenderer>().enabled = false;


    }

}

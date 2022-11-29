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
        animator.SetTrigger("hurt");

        if(currentVida <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy MORREU");

        //die animation
        animator.SetBool("die", true);

        //disable the enemy
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;


    }

}

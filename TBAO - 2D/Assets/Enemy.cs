using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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

        if(currentVida <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy MORREU");
        
        //die animation

        //disable the enemy


    }

}

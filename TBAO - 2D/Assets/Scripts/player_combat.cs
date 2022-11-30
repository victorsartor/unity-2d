using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_combat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.10f;
    public int attackDamage = 50;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
      
    }

    void Attack()
    {
        //dar ataque
        animator.SetTrigger("Attack");
        //detectar inimigos no range
        Collider2D [] hitEnemis = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //dar dano
        foreach(Collider2D enemy in hitEnemis)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }


    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
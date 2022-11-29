using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_combat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Attack();
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
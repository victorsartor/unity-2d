using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_combat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

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
            Debug.Log("We hit" + enemy.name);
        }
    }


    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
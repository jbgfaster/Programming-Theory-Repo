using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomber : Enemy
{

    void Update()
    {
        if (canMove)
        {
            MoveToPlayer();
        }
    }
    private void Bang()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            gameManager.Damage(10);
            Bang();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBomber : Enemy
{
    //INHERITANCE This class inherit Enemy class  use method MoveToPlayer, but after Collide with player destroy self and damage Player
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
            GameManager.Instance.Damage(10);
            Bang();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : EnemyMovment
{
    [SerializeField] float shootDistance = 20.0f;
    [SerializeField] GameObject bullet;
    private bool canShoot = true;

    void Update()
    {
        canMove = shootDistance < Mathf.Abs(( transform.position- tower.transform.position).magnitude);
        if(!canMove && canShoot)
        {
            canShoot = false;
            Shoot();
        }
        if(canMove)
        {
            MoveToPlayer();
        }
    }
    void Shoot()
    {
        transform.LookAt(tower.transform);
        GameObject temp =  Instantiate(bullet,transform.position, transform.localRotation);
        temp.transform.LookAt(tower.transform);
        Invoke("ShootTimer", 1);
    }
    void ShootTimer()
    {
        canShoot = true;
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] float shootRate = 1.0f;
    [SerializeField] float shootRange = 10.0f;
    [SerializeField] float timeLive = 7.0f;

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject sideAim;

    void Awake()
    {
        InvokeRepeating("Shoot",0, shootRate);
        Invoke("TimeOut", timeLive);
    }

    void Shoot()//ABSTRACTION class count all actions about shooting mechanic
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float magn=100.0f;
        GameObject currentEnemy=null;
        foreach (GameObject enemy in enemies)
        {
            float magnNew = (enemy.transform.position - transform.position).magnitude;
            if (magnNew<magn && magnNew<=shootRange)
            {
                magn = magnNew;
                currentEnemy = enemy;
            }            
        }        
        if (currentEnemy!=null)
        {            
            GameObject temp = Instantiate(bullet,transform.position,transform.rotation);
            temp.tag = "PlayerBullet";
            temp.transform.LookAt(currentEnemy.transform);
        }
    }
    void TimeOut()
    {
        Destroy(gameObject);
    }
}

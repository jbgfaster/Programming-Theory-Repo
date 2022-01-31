using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject tower;
    [SerializeField] float speed = 10.0f;
    public bool canMove = true;
    // Start is called before the first frame update
    void Awake()
    {
        tower = GameObject.Find("Tower");
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            MoveToPlayer();
        }        
    }

    public virtual void MoveToPlayer()
    {
        Vector3 side = tower.transform.position - transform.position;
        transform.Translate(side.normalized * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public GameObject tower;
    public GameManager gameManager;
    [SerializeField] float speed = 10.0f;
    public bool canMove = true;
    // Start is called before the first frame update
    void Awake()
    {
        tower = GameObject.Find("Tower");
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed=100.0f;
    [SerializeField] float bonds = 50.0f;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        Invoke("DestroySelf", 5);
        transform.Rotate(Vector3.right * 90);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")&&CompareTag("EnemyBullet"))
        {
            gameManager.Damage(1);
            DestroySelf();
        }
        else if(other.CompareTag("Enemy") && CompareTag("PlayerBullet"))
        {
            Destroy(other.gameObject);
            DestroySelf();
        }
        
        
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}

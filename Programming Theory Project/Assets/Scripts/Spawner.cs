using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] float spawnBonds;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if(!gameManager.isGame)
        {
            return;
        }

        float spawnBondX = Random.Range(-spawnBonds-20, spawnBonds+20);
        float spawnBondY = Random.Range(-spawnBonds - 20, spawnBonds + 20);
        Instantiate(enemies[Random.Range(0,enemies.Length)],new Vector3(spawnBondX,1, spawnBondY), enemies[Random.Range(0, enemies.Length)].transform.rotation);
    }
}

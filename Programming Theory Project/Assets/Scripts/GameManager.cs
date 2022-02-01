using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject tower;
    public GameObject[] towerUpgrades;
    public Slider hpSlider;
    public float hp = 100;
    public bool isGame=true;
    public static GameManager Instance{get;private set;}//INCAPSULATION gamemanager can only be get from another places in code, but not set.


    void Start()
    {
    	Instance=this;
        tower = GameObject.Find("Tower");
    }

    // Update is called once per frame
    void Update()
    {
        hpSlider.SetValueWithoutNotify(hp);
    }
    public void Damage(float dmg)
    {
        hp -= dmg;
        if(hp<1)
        {
            isGame = false;
            Debug.Log("Game Over");
        }
    }

}

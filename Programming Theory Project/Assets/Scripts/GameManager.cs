using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject tower;
    public Slider hpSlider;
    public float hp = 100;
    public bool isGame=true;
    // Start is called before the first frame update
    void Start()
    {
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

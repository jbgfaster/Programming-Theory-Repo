using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusWeapon : Bonus
{
	public GameObject bonus;

	public override void TakeBonus()//POLYMORPHISM in base class this method look like how virtual and get some health to tower, after override it's get gun weapon
    {
		Instantiate(bonus,GameManager.Instance.towerUpgrades[0].transform);
	}
}

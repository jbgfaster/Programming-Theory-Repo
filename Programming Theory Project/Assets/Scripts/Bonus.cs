using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    private void OnMouseDown()
    {
    	TakeBonus();
    	Destroy(gameObject);
    }
    public virtual void TakeBonus()
    {
    	GameManager.Instance.Damage(-10);
    }
}

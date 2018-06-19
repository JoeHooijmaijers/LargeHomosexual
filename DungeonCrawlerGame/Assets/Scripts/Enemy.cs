using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : LivingBeing {

    
    public int physicality { get; set; }
    public int magicality { get; set; }
    public int accuracy { get; set; }
    public int moveSpeed { get; set; }
    public int attackSpeed { get; set; }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GetHit()
    {

    }

    public void LoseHP(int damage, DamageType damageType)
    {

    }

    public void GainHP(int gain)
    {

    }

    
}

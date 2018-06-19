using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LivingBeing {

    public float movementSpeed = 1.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Horizontal player movement
		if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < 0.5f)
        {
            MoveHorizontally();
        }
        //Vertical player movement
        if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") > 0.5f)
        {
            MoveVertically();
        }

        //Basic Attack
        if (Input.GetMouseButtonDown(1))
        {
            BasicAttack();
        }
	}

    private void MoveHorizontally()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0f));
    }

    private void MoveVertically()
    {
        transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime));
    }

    private void BasicAttack()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movewallcontroller : MonoBehaviour {
    //public Bottan bottan;
    Rigidbody2D Rigidbody2D;
    Bottan _bottan;
    public bool bottanA;
	// Use this for initialization
	void Start () {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (bottanA)
        {
            WallUp();
        }
        if (!bottanA)
        {
            WallDown();
        }
	}

    public void WallUp()
    {
            this.Rigidbody2D.velocity = Vector2.up * 10.0f;
    }

    public void WallDown()
    {
            this.Rigidbody2D.velocity = Vector2.up * 0;
    }
    public void MoveWallBottan_ON()
    {
        bottanA = true;
    }
    public void MoveWallBottan_Off()
    {
        bottanA = false;
    }
}

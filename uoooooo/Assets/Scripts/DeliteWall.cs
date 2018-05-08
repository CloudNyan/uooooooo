using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliteWall : MonoBehaviour {
    Rigidbody2D Rigidbody2D;
    Delite_sw _Delite_sw;
    public bool Delite_sw;
    BoxCollider2D BoxCollider2D;
    // Use this for initialization
    void Start () {
        BoxCollider2D = GetComponent<BoxCollider2D>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Delite_sw)
        {
            Delite_Start();
        }
    }
    void Delite_Start()
    {
        this.gameObject.SetActive(false);
    }
    void Delite_fix()
    {
        this.gameObject.SetActive(true);
    }
    public void Delite_SW_ON()
    {
        Delite_sw = true;
    }
}

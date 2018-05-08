using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniStop : MonoBehaviour {
    Rigidbody2D rigid2D;
    // Use this for initialization
    void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveyukaController : MonoBehaviour {
    Rigidbody2D rigid2D;
    float moveArrow;
    float span = 3.0f;
    float delta = 0;
    // Use this for initialization
    void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
        moveArrow = 2.0f;
    }
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            moveArrow = moveArrow * -1.0f;
        }
        rigid2D.velocity = new Vector2(4.0f * moveArrow, rigid2D.velocity.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniController : MonoBehaviour {
    Rigidbody2D rigid2D;
    float moveArrow;
    float UniHP;
    bool DMGflag = false;
    // Use this for initialization
    void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
        moveArrow = 1.0f;
        UniHP = 5.0f;
    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine("UniDMG");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveArrow = moveArrow * -1.0f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            Destroy(this.gameObject);
        }
    }
    public IEnumerator UniDMG()
    {  
        //移動&反転
        if (moveArrow != 0)
        {
            rigid2D.velocity = new Vector2(3.0f * moveArrow, rigid2D.velocity.y);
            transform.localScale = new Vector3(5 * moveArrow, 5, 1);
        }
        if (DMGflag)
        {
            yield return new WaitForSeconds(0.8f);
            DMGflag = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    Idel,
    Walk,
    Crouch,
    Ladder,
    Push,
    Dead,
}

public class PlayerController : MonoBehaviour {

    GameObject Director;

    public Rigidbody2D rigid2D;
    Animator animator;

    float Runspeed = 12.0f;
    float Jumpspeed = 30.0f;

    bool isX;
    public bool onGround;

    public PlayerState state;

    // Use this for initialization
    void Start () {
        Director = GameObject.Find("GameDirector");

        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        isX = true; //trueは右向き
        state = PlayerState.Idel;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (state == PlayerState.Dead) return;
        if (state == PlayerState.Ladder)
        {
            Ladder();
            return;
        }

        if (onGround)
        {
            if (state == PlayerState.Idel)
            {
                animator.SetTrigger("Blink");
            }

            if (state == PlayerState.Walk)
            {
                animator.SetTrigger("Run");
            }
        }

        //ジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        Walk();

        //Fall
        if (rigid2D.velocity.y < 0)
        {
            animator.SetTrigger("Fall");
        }

        //しゃがみ
        if (Input.GetKey(KeyCode.DownArrow))
        {
            state = PlayerState.Crouch;
            animator.SetTrigger("Crouch");
        }

        //しゃがみ解除
        if (Input.GetKeyUp(KeyCode.DownArrow)) state = PlayerState.Idel;
    }

    void Ladder()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.gravityScale = 10;
            state = PlayerState.Idel;
            return;
        }
        rigid2D.gravityScale = 0;
        rigid2D.velocity = Vector2.up * 0.0f;
        animator.SetTrigger("ladder");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid2D.velocity = Vector2.up * 3.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigid2D.velocity = Vector2.up * -3.0f;
        }
    }

    void Jump()
    {
        if (state == PlayerState.Crouch) return;
        if (!onGround) return;

        this.rigid2D.velocity = Vector2.up * Jumpspeed;
        animator.SetTrigger("Jump");
        onGround = false;
    }

    public void Walk()
    {
        if (state == PlayerState.Crouch) return;
        //移動&反転
        float moveArrow = 0;
        if (Input.GetKey(KeyCode.LeftShift)) Runspeed = 6.0f;
        if (Input.GetKeyUp(KeyCode.LeftShift)) Runspeed = 12.0f;
        if (Input.GetKey(KeyCode.RightArrow)) moveArrow = 1.0f;
        if (Input.GetKey(KeyCode.LeftArrow)) moveArrow = -1.0f;
        if (moveArrow != 0)
        {
            rigid2D.velocity = new Vector2(Runspeed * moveArrow, rigid2D.velocity.y);

            transform.localScale = new Vector3(4 * moveArrow, 4, 1);
            //体の向き変更
            if (this.transform.localScale.x < 0) isX = false;
            else { isX = true; }

            state = PlayerState.Walk;
        }
        else
        {
           state = PlayerState.Idel;
        }
    }
    public void Push()
    {
        state = PlayerState.Push;
        animator.SetTrigger("Push");
    }
    void Dead()
    {
        if(state != PlayerState.Dead)
        {
            return;
        }
        animator.SetTrigger("Dead");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (state == PlayerState.Dead) return;
        if (collision.gameObject.CompareTag("Enemy"))
        {
            state = PlayerState.Dead;
            Dead();
        }
        else
        {
            return;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour {
    [SerializeField] PlayerController Pl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "hasigo_0") return;
            if (collision.gameObject.CompareTag("Ground"))
        {
            PlayerController _Pl = Pl.GetComponent<PlayerController>();
            
            _Pl.onGround = true;
            
        }
        else
        {
            return;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            PlayerController _Pl = Pl.GetComponent<PlayerController>();
            _Pl.onGround = false;
        }
        else
        {
            return;
        }
    }
}
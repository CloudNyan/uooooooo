using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oneway : MonoBehaviour {
    CapsuleCollider2D CapsuleCollider2D;
	// Use this for initialization
	void Start () {
        CapsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine("Enumerator");
        }

    }
    IEnumerator Enumerator()
    {
        CapsuleCollider2D.enabled = false;
        yield return new WaitForSeconds(.3f);
        CapsuleCollider2D.enabled = true;
    }
}

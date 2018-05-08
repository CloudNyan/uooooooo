using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottan : MonoBehaviour {
    [SerializeField] GameObject movewall;
    Movewallcontroller _movewall;
	// Use this for initialization
	void Start () {
        _movewall=movewall.GetComponent<Movewallcontroller>();
    }
	
	// Update is called once per frame
	void Update () {
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        _movewall.MoveWallBottan_ON();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        _movewall.MoveWallBottan_Off();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_Brock : MonoBehaviour {
    [SerializeField] GameObject Player;
    PlayerController _Player;
    // Use this for initialization
    void Start () {
        _Player = Player.GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player") return;
            _Player.Push();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player") return;
        _Player.Walk();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delite_sw : MonoBehaviour {
    [SerializeField] GameObject Delitewall;
    DeliteWall _Delitewall;
    // Use this for initialization
    void Start () {
        _Delitewall = Delitewall.GetComponent<DeliteWall>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        _Delitewall.Delite_SW_ON();
    }
}

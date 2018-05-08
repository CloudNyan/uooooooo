using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {
    GameObject HPgauge;
    public PlayerController PlayerController;
    // Use this for initialization
    void Start ()
    {
        HPgauge = GameObject.Find("HPgauge");
    }
	
	// Update is called once per frame
	void Update () {
    }
    public void HPDirector()
    {

    }
}

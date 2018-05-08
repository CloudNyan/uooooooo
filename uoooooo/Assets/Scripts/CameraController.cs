using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("PlayerSprite");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos = player.transform.position;
        transform.position = new Vector3(playerpos.x, playerpos.y + 4.155003f, transform.position.z);
    }
}

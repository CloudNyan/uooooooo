using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
        if(playerController != null && Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerController.state = PlayerState.Ladder;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController playerController = collision.GetComponent<PlayerController>();
        if (playerController != null)
        {
            playerController.rigid2D.gravityScale = 10;
            playerController.state = PlayerState.Idel;
        }
    }
}

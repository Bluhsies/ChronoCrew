using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript5 : MonoBehaviour
{
    private float respawn_X;
    private float respawn_Y;

    void Start()
    {
        var startPos = this.gameObject.transform.position;
        respawn_X = startPos.x;
        respawn_Y = startPos.y;
        //sets the spawn position at the start of the game
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DeathTrigger") //checks for 2D trigger with the name "DeathTrigger"
        {
            var respawnPos = this.gameObject.transform.position;
            respawnPos.x = respawn_X;
            respawnPos.y = respawn_Y;
            this.gameObject.transform.position = respawnPos;
            //sets players position to current respawn position(default is starting position, can be changed in unity component field)
        }
        if (other.gameObject.tag == "Checkpoint")
        {
            var checkpointPos = this.gameObject.transform.position;
            respawn_X = checkpointPos.x;
            respawn_Y = checkpointPos.y;
            //sets the respawn position to the checkpoint position
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Vector2 respawnPoint;
    [SerializeField]
    private string otherPlayerTag;
    public bool caught;
    

    void Start()
    {
        caught = false;
        //Set the starting point as the respawn point
        respawnPoint = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == otherPlayerTag)
        {
            
            //When Collided with other player return them to the start point
            transform.position = respawnPoint;
            //When collided caught triggers effects in ScoreScript
            caught = true;

            
        }
    }


}

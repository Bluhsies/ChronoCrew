using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{

    // This script is attached to the items in the maps. It will compare the tags for "Player1" and "Player2" which have been assigned to each player.
    // When one of the player characters contacts it via a 2D collider, it will destroy the object via the Destroy() function, by referencing "this" which is the object the script is attached to.

    public void OnTriggerEnter2D(Collider2D item)
    {
        if (item.gameObject.CompareTag("Player2") || item.gameObject.CompareTag("Player1"))
        {
            Destroy(this.gameObject);
        }
    }

}

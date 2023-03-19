using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    // This creates an object from the ScoreCounter class to be called in the function.
    [SerializeField]
    private ScoreCounter sc;

    // When the player collides with an Item (an object in the game tagged as an Item) it will update the score value on the screen by 1 point.
    void OnTriggerEnter2D(Collider2D ItemCheck)
    {
        if (ItemCheck.gameObject.CompareTag("Item"))
        {
            sc.UpdateScoreValue(1);

        }
        //Debug.Log(gameObject.name);


    }

}

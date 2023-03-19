using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LivesDecrease5 : MonoBehaviour
{
    // This creates an object from the ScoreCounter class to be called in the function.
    [SerializeField]
    private LivesText5 lc;

    // When the player collides with an Item (an object in the game tagged as an Item) it will update the score value on the screen by 1 point.
    void OnTriggerEnter2D(Collider2D ItemCheck)
    {
        if (ItemCheck.gameObject.CompareTag("DeathTrigger"))
        {
            lc.UpdateScoreValue(+1);

        }
        //Debug.Log(gameObject.name);


    }

}
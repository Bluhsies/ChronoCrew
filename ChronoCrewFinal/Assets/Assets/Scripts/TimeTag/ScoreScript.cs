using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

    public static int scoreNumber = 0;
    Text score;
    public PlayerCollision playercollision;
    string whichText;
    public int selector;
    public int round;
    [SerializeField]
    public string LoadScene;

    void Awake()
    {
        selector = 1;
        whichText = gameObject.name;
        round = 1;

    }


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        //Display Score: 0 at the start
        score.text = "Score: " + scoreNumber;
    }

    // Update is called once per frame
    void Update()
    {
            
        if (playercollision.caught == true)
        {
            if (selector == 1 && whichText == "Player1Score")
            {
                
                //If thise code is on Player1Score and selector = 1 and the player has been caught increase score by 1
                scoreNumber += 1;
                // Set text to score value
                score.text = "Score: " + scoreNumber;
                // If all of the above is correct increase round by 1 and make the other player IT
                round += 1;
                selector = 2;
                Debug.Log("selector swapped to: " + selector);

               
                SceneManager.LoadScene(LoadScene);
               
            }
            else if (selector == 2 && whichText == "Player2Score")
            {
                // Set text to score value
                Debug.Log("Player 2 score plus 1");
                // Same as above but for Player2Score
                scoreNumber += 1;
                // Set text to score value
                score.text = "Score: " + scoreNumber;
                round += 1;
                selector = 1;
                Debug.Log("selector swapped to: " + selector);


            }

            //Once score and round has been increased and IT has changed return caught to false
            playercollision.caught = !playercollision.caught;

        }




    }
}


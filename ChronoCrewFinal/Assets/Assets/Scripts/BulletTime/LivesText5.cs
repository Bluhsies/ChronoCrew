using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LivesText5 : MonoBehaviour
{
    // Values which can be amended via the inspector, relating to the score, except for the scoreText which is constant.
    // The scoreValue can be increased depending on how many points each destroyed item provides and the winScore can be amended depending on how many are required to win.
    // LoadScene will load the scene which has been input in the inspector. These will be win screens.
    public Text scoreText;
    [SerializeField]
    private int scoreValue;
    [SerializeField]
    private int winScore;
    [SerializeField]
    public string LoadScene;
    [SerializeField]
    public string PlayerScore;


    // Inialising the value of scoreValue to 0.
    // It will also set the text in the ScoreUI to Score:.
    void Start()
    {
        scoreValue = 3;
        UpdateScoreText();
    }

    void Update()
    {
    }

    // UpdateScoreValue is updated each time the Collider in the ScoreTrigger script is accessed when an item is destroyed. This will increase the player's score and update the text
    // on the screen by 1 point for each item destroyed.
    // When a player destroys the amount of items in the winScore, it will load the scene which has been input in the inspector. This is usually a win screen.
    public void UpdateScoreValue(int scoreUpdate)
    {
        scoreValue -= scoreUpdate;

        UpdateScoreText();

        if (scoreValue == 0)
        {
            SceneManager.LoadScene(LoadScene);
        }
    }

    // This function is called when a player destroys an item to amend the scoreValue in the game. It will also update the initial score value to zero.
    void UpdateScoreText()
    {
        scoreText.text = PlayerScore + " " + scoreValue;
    }

}
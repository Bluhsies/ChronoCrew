using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Announcer : MonoBehaviour
{
    Text announce;
    public ScoreScript scoreScript;

    void Start()
    {
        announce = GetComponent<Text>();
        //Set the text to Round: 1
        announce.text = "Round " + scoreScript.round;
    }

    // Update is called once per frame
    void Update()
    {
        //Set the text to state the round
        announce.text = "Round " + scoreScript.round;
    }
}
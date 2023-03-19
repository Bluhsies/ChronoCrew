using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITSelectorPlayer1 : MonoBehaviour
{
    [SerializeField]
    GameObject Object1;
    public ScoreScript scoreScript;
    public PlayerCollision playercollision;
    public Renderer rend;
    int IT;

    void Start()
    {
        rend = GetComponent<Renderer>();
        //Set Object to invisible
        rend.enabled = false;
        //If selector is for Player 1 set IT to visible
        if (scoreScript.selector == 1)
        {
            rend.enabled = true;
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        IT = scoreScript.selector;
        Debug.Log("Selector p1 : " + IT);
        if (IT == 1)
        {
            //If selector is for Player 1 set IT to visible
            rend.enabled = true;
        }
        else if (IT == 2)
        {
            //If selector is for Player 2 set IT to invisible
            rend.enabled = false;
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITSelectorPlayer2 : MonoBehaviour
{
    [SerializeField]
    GameObject Object1;
    public ScoreScript scoreScript;
    int IT;
    public PlayerCollision playercollision;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        //Set Object to invisible
        rend.enabled = false;
        //If selector is for Player 1 set IT to visible
        if (scoreScript.selector == 2)
        {
            rend.enabled = true;
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        IT = scoreScript.selector;
        Debug.Log("Selector p2 : " + IT);
        if (IT == 2)
        {
            //If selector is for Player 2 set IT to visible
            rend.enabled = true;
        }
        else if (IT == 1)
        {
            rend.enabled = false;
            //If selector is for Player 1 set IT to invisible
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerKilled : MonoBehaviour
{
    [SerializeField] GameObject player1, player2;
    // Update is called once per frame
   

    public void FixedUpdate()
    {
        if (player1 == null) /*Debug.LogWarning("Add code to change scene here.");*/
        {
            SceneManager.LoadScene(19);
        }
        
        if (player2 == null)
        {
            SceneManager.LoadScene(20);
        }
    }
}

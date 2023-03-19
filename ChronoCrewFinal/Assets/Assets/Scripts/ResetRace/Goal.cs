using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player1")
        {
            SceneManager.LoadScene("Player1Win4");
        }
        if (other.gameObject.tag == "Player2")
        {
            SceneManager.LoadScene("Player2Win4");
        }
    }
}

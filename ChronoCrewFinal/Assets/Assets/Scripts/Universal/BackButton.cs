using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BackButton : MonoBehaviour
{

    [SerializeField] public string back; // Allows the user to add the scene name they want to go back to, using the back button, in the inspector.

    public void Back()
    {

        SceneManager.LoadScene(back); // Will load the requested scene from the inspector.

    }

}

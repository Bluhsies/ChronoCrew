using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{

    // Allows for the string LevelLoad to be changed in the inspector, which will loada particular scene.
    [SerializeField]
    public string LevelLoad;

    void Update()
    {

        // When one of the players presses the Return button, it will load the next scene which has been added in the inspector by taking the scene name as a string.
        if (Input.GetKeyDown(KeyCode.Return))
        {

            SceneManager.LoadScene(LevelLoad);

        }

    }

}

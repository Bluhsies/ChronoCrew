using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    // This will load the settings menu for the game, by loading that particular scene SettingsMenu.
    public void OpenSettings()
	{
		SceneManager.LoadScene("SettingsMenu");
	}

	// This will return the user to the main menu, by using the back button found in the settings menu.
	public void Return()
	{
		SceneManager.LoadScene("Menu");
	}

	// This will load the first level of the game, by loading a particular scene called Map1.
	public void StartLevel()
	{
		SceneManager.LoadScene("Map1");
	}


	// This will exit the entire game. A Debug.Log has been added to confirm this, as it will not quit the application in Unity.
	public void ExitGame()
	{
		Debug.Log("Quit!");
		Application.Quit();
	}

}

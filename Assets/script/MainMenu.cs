using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame() {
		// pindah scene
		// PlayerPrefs.SetString("name", "Gilang A");
		PlayerPrefs.SetInt ("score", 9999);
		PlayerPrefs.Save ();
		Application.LoadLevel("scene1");
	}

	public void Settings() {
		
	}

	public void HighScore() {
		Application.LoadLevel ("scoreBoard");
	}

	public void QuitGame() {
		Application.Quit();
	}

	public void gantiName(string text) {
		PlayerPrefs.SetString ("name", text);
		PlayerPrefs.Save ();
	}
}

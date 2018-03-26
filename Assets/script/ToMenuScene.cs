using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenuScene : MonoBehaviour {
	void OnTriggerEnter(Collider col) {
		if (col.CompareTag("Player")) {
			string Url = "https://pbd-unity.000webhostapp.com/insert_score.php?nama=" + PlayerPrefs.GetString ("name") + "&score=" + PlayerPrefs.GetInt("score");
			WWW www = new WWW(Url);
			SceneManager.LoadScene("MainMenuScene");

		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSecondScene : MonoBehaviour {
	void OnTriggerEnter(Collider col) {
		if (col.CompareTag("Player")) {
			Debug.Log("namanya" + PlayerPrefs.GetString ("name"));
			PlayerPrefs.SetInt ("score", PlayerPrefs.GetInt ("score1"));
			PlayerPrefs.Save ();
			SceneManager.LoadScene("scene3");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score2 : MonoBehaviour {
	public string name;
	public int scores;
	// Use this for initialization
	void Start () {
		name = PlayerPrefs.GetString ("name");
		Debug.Log ("Kamu Naik level, " + name);
		scores = PlayerPrefs.GetInt ("score");
		StartCoroutine (waiter ());
	}

	IEnumerator waiter() {
		while (true) {
			yield return new WaitForSeconds(1);
			scores--;
			PlayerPrefs.SetInt ("score2", scores);
			PlayerPrefs.Save ();
			Debug.Log (scores);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUG1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(PlayerPrefs.GetString ("name"));	
	}
}

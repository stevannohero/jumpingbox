using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerScoreList : MonoBehaviour {

    public GameObject playerEntryPrefab;
    private scoreManager mScoreManager;

	// Use this for initialization
	void Start () {
        mScoreManager = GameObject.FindObjectOfType<scoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (mScoreManager == null)
        {
            Debug.LogError("mScoreManager is null");
        }

        while (this.transform.childCount > 0)
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        string[] names = mScoreManager.getPlayerNames();
        foreach (string name in names)
        {
            GameObject go = (GameObject)Instantiate(playerEntryPrefab);
            go.transform.SetParent(this.transform);
            go.transform.Find("Names").GetComponent<Text>().text = name;
            go.transform.Find("Scores").GetComponent<Text>().text = mScoreManager.getScore(name).ToString();
        }
    }
}

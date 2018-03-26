using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class scoreManager : MonoBehaviour {
    Dictionary<string, int> playerScores;   

	// Use this for initialization
	void Awake () {
        playerScores = new Dictionary<string, int>();
        setScore("gilang", 10010);
        setScore("hero", 10020);
        setScore("rip", 1003);
        setScore("eki", 1004);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public string[] getPlayerNames()
    {
        return playerScores.Keys.ToArray();
    }

    public void the_init()
    {
        if (playerScores != null)
            return;
        playerScores = new Dictionary<string, int>();
    }

    public int getScore(string username)
    {
        the_init();
        if (playerScores.ContainsKey(username) == false)
        {
            return 0;
        }
        return playerScores[username];
    }

    public void setScore(string username, int score)
    {
        the_init();
        playerScores[username] = score;
    }
}

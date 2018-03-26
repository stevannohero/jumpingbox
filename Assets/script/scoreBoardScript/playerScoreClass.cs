using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

[Serializable]
class playerScoreHolderClass
{
    public playerScoreHolder[] info;
}

public class playerScoreClass : MonoBehaviour
{
    public GameObject playerEntryPrefab;
    private IEnumerator coroutine;
    private string Url;

	public void Kembali() {
		Application.LoadLevel ("MainMenu");
	}


    // Sample JSON for the following script has attached.
    IEnumerator Start()
    {
        Url = "https://pbd-unity.000webhostapp.com/get_highscore.php";
        WWW www = new WWW(Url);
        yield return www;

        if (www.error == null)
        {
            Debug.Log(www.text);
            playerScoreHolderClass pshs = JsonUtility.FromJson<playerScoreHolderClass>(www.text);
            Debug.Log(pshs.ToString());

            foreach (playerScoreHolder psh in pshs.info)
            {
                GameObject go = (GameObject)Instantiate(playerEntryPrefab);

                go.transform.SetParent(this.transform);
                go.transform.Find("Names").GetComponent<Text>().text = psh.nama;
                go.transform.Find("Scores").GetComponent<Text>().text = psh.score.ToString();
            }
        }
        else
        {
            Debug.Log("ERROR: " + www.error);
        }
    }
}
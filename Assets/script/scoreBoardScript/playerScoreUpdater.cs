using UnityEngine;
using System.Collections;

public class playerScoreUpdater : MonoBehaviour
{
    public playerScoreHolder psh;
    public string nama;
    public string score;
    private string Url;

    IEnumerator Start()
    {
        psh = new playerScoreHolder();
        Url = "https://pbd-unity.000webhostapp.com/insert_score.php?nama=" + nama + "&score=" + score;
		WWW www = new WWW(Url);

        yield return www;
        if (www.error != null)
        {
            Debug.Log(www.error);
        } else
        {
            Debug.Log(www.text);
        }
    }
}
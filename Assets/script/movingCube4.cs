using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingCube4 : MonoBehaviour
{
	public float speed;
	Vector3 pos;
	Vector3 pointA;
	Vector3 pointB;

    IEnumerator Start()
    {
		pos = transform.position;
		pointA = new Vector3(pos.x, pos.y - 10.0f, pos.z);
		pointB = new Vector3(pos.x, pos.y + 10.0f, pos.z);
        while(true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, speed));
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, speed));
        }
    }
   
    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i = 0.0f;
        var rate = 1.0f/time;
        while(i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
}

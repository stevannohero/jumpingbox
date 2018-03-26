using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	private bool onGround;
	private float jumpPressure;
	private float minJump;
	private float maxJumpPressure;
	private Rigidbody rbody;
	public AudioSource jump;

	// Use this for initialization
	void Start () {
		//initialize all variable
		onGround = true;
		jumpPressure = 0;
		minJump = 20f;
		maxJumpPressure = 30f;
		rbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		//bagian translasi
		transform.Translate(0.2f * Input.GetAxis("Horizontal"), 0f, 0.2f * Input.GetAxis("Vertical"));

		Debug.Log ("status : " + onGround);

		//bagian lompat-lompat
		if (onGround) {
			//holding jump button
			if (Input.GetButton ("Jump") /*|| Input.GetMouseButtonDown(0)*/) {
				jump.Play();
				if (jumpPressure < maxJumpPressure) {
					jumpPressure += Time.deltaTime * 20f;
				} else {
					jumpPressure = maxJumpPressure;
				}
			}
			//not holding jump button
			else {
				if (jumpPressure > 0f) {
					if (jumpPressure < minJump) {
						jumpPressure = minJump;
					}
					rbody.velocity = new Vector3 (0f, jumpPressure, 0f);
					onGround = false;
					jumpPressure = 0;
				}
			}
		}
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag ("ground")) {
			onGround = true;
		}
	}
}

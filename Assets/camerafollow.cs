using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

	public GameObject ball;
	public Vector3 offset;
	public float lerprate;
	public bool gameover;

	// Use this for initialization
	void Start () {
		offset = ball.transform.position - transform.position;
		gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameover) {
			Follow ();
		}
	}

	void Follow() {
		Vector3 pos = transform.position;
	    Vector3 targetPos = ball.transform.position - offset;
		pos= Vector3.Lerp (pos, targetPos, lerprate * Time.deltaTime);
		transform.position = pos;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {

	// Use this for initialization
	public int score = -15;

	public GameObject balle;

	public Ball balleSc;
	float force = 0;
	Vector3 lastBallStop;
	void Start () {
		lastBallStop = balleSc.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!balleSc.run)
			return ;
		if (Input.GetKey("space") && balleSc.speed == 0.0f)
		{
			force += 0.05f;
		}
		else if (force != 0.0f)
		{
			balleSc.speed += force;
			force = 0;
			score += 5;
			Debug.Log("Score: " + score);
		}
		if (balleSc.speed == 0.0f)
		{
			lastBallStop = balleSc.transform.position;
		}
		transform.position = lastBallStop + new Vector3(0, -force, 0);
	}
}

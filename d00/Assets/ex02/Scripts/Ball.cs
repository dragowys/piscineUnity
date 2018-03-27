using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


	public float speed = 0.0f;
	bool up = true;
	public float radius = 0.3f;
	public bool run = true;
	// Use this for initialization
	void Start () {
		
	}
	

	// Update is called once per frame
	void Update () {
		if (!run)
			return ;
		if (speed != 0.0f)
		if (up)
			transform.Translate(new Vector3(0, speed, 0));
		else
			transform.Translate(new Vector3(0, -speed, 0));
		float t = 5f - radius;
		if (up && transform.position.y > t)
		{
			transform.Translate(new Vector3(0, t - transform.position.y, 0));
			up = false;
		}
		else if (!up && transform.position.y < -t)
		{
			transform.Translate(new Vector3(0, -t - transform.position.y, 0));
			up = true;
		}
		speed *= 0.98f;
		speed -= 0.01f;
		if (speed < 0)
		{
			speed = 0;
			up = true;
		}
		if (transform.position.y > 3 - radius && transform.position.y < 3 + radius && speed < 0.15)
		{
			transform.Translate(new Vector3(0, 0, 10));
			run = false;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	// Use this for initialization
	public bool run = true;
	public float speed = 0.1f;
	public int score = 0;
	void Start () {
		
	}
	
	public void Died() {
		run = false;
		Debug.Log("Score: " + score);
		Debug.Log("Time: " + Mathf.RoundToInt(Time.time) + "s");
	}

	// Update is called once per frame
	float up = 0;
	void Update () {
		if (!run)
			return ;
		if (Input.GetKeyDown("space"))
			up += 1f;
		if (up > 0.0f)
		{
			up -= 0.1f;
			transform.Translate(new Vector3(0, 0.1f, 0));
		}
		else
			transform.Translate(new Vector3(0, -0.1f, 0));
		speed *= 1.001f;
		if (transform.position.y <= -4f)
			Died();
	}
}

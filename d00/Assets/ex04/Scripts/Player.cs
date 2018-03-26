using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public string keyUp;
	public string keyDown;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float max = 4.5f - transform.localScale.y * 0.5f;
		if (Input.GetKey(keyUp))
		{
			transform.Translate(new Vector3(0, 0.2f, 0));
			if (transform.position.y > max)
				transform.position = new Vector3(transform.position.x, max, transform.position.z);
		}
		if (Input.GetKey(keyDown))
		{
			transform.Translate(new Vector3(0, -0.2f, 0));
			if (transform.position.y < -max)
				transform.position = new Vector3(transform.position.x, -max, transform.position.z);
		}
	}
}

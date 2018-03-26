using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	public string key;
	public float speed = 0f;
	void Start () {
		if (speed == 0f)
			speed = Random.Range(0.15f, 0.4f);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key) && transform.position.y < 2.5f && transform.position.y > -2.5f)
        {
            Debug.Log("Precision: " + Mathf.Abs(transform.position.y));
			Destroy(gameObject);
        }
		if (transform.position.y < -10.0f)
			Destroy(gameObject);

		transform.Translate(new Vector3(0, -speed, 0));
	}
}

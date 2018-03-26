using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	float size = 10;
	float souffle = 5;

	// Update is called once per frame
	void Update () {
		size -= 0.1f;
		souffle += 3.0f / 60.0f;
		if (souffle > 5)
			souffle = 5;
        if (Input.GetKeyDown("space") && souffle > 1f)
        {
			souffle -= 1;
			size += 3.0f;
            // Debug.Log(Input.mousePosition);
        }		
		if (size <= 0 || size > 50)
		{
			Debug.Log("Balloon life time: " + Mathf.RoundToInt(Time.time) + "s");
			Destroy(gameObject);
		}
		transform.localScale = new Vector3(0.1f, 0.1f, 0) * size;
	}
}

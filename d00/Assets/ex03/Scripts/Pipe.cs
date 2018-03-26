using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {


	public GameObject bird;
	public Bird birdS;

	// Use this for initialization
	void Start () {
		
	}
	
	void Pop () {
		transform.position = new Vector3(5f, 0, 0);
	}

	// Update is called once per frame
	void Update () {
		if (!birdS.run)
			return ;
		if (transform.position.x > -2 && transform.position.x - birdS.speed < -2)
			if (bird.transform.position.y > 1.5f || bird.transform.position.y < -1.8f)
				birdS.Died();
			else
				birdS.score += 5;
		transform.Translate(new Vector3(-birdS.speed, 0, 0));
		if (transform.position.x < -4)
			Pop();
	}
}

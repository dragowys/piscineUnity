using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeSpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject cubeA;
	public GameObject cubeB;
	public GameObject cubeC;
	public float delaySpawn = 1.0f;
	float lastTime;
	void Start () {
		lastTime = Time.time;	
	}
	// Update is called once per frame
	void Update () {
		if (Time.time > lastTime)
		{
			lastTime += delaySpawn;
			float rand = Random.Range(0f, 3f);
			if (rand <= 1f)
				GameObject.Instantiate(cubeA, new Vector3(-2, 5, 0), Quaternion.identity);
			else if (rand <= 2f)
				GameObject.Instantiate(cubeB, new Vector3(0, 5, 0), Quaternion.identity);
			else if (rand <= 3f)
				GameObject.Instantiate(cubeC, new Vector3(2, 5, 0), Quaternion.identity);
		}
	}
}

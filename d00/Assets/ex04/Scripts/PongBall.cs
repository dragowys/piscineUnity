using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour {



	public GameObject player1;
	public GameObject player2;

	Vector2 direction;
	int score1 = 0;
	int score2 = 0;
	float speed;
	void Reset() {
		direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
		direction.Normalize();
		transform.position = new Vector3();
		speed = 0.1f;
		if (Mathf.Abs(direction.x) < 0.5f)
			Reset();
	}

	void PrintScore() {
		Debug.Log("Player 1: " + score1 + " | Player 2: " + score2);
	}

	// Use this for initialization
	void Start () {
		Reset();
	}
	
	// Update is called once per frame
	void Update () {
		float max = 4.5f - transform.localScale.y * 0.5f;
		transform.Translate(direction * speed);
		if (transform.position.y > max)
		{
			transform.Translate(0, max - transform.position.y, 0);
			direction.y = -direction.y;
		}
		else if (transform.position.y < -max)
		{
			transform.Translate(0, -max - transform.position.y, 0);
			direction.y = -direction.y;
		}
		max = 8f - 0.125f - transform.localScale.x * 0.5f;
		if (transform.position.x + direction.x * speed >= max && transform.position.x < max)
		{
			float sc = player2.transform.localScale.y * 0.5f + transform.localScale.y * 0.5f;
			if (transform.position.y <= player2.transform.position.y + sc &&
				transform.position.y >= player2.transform.position.y - sc)
			direction.x = -direction.x;
			speed += 0.02f;
		}
		else if (transform.position.x + direction.x * speed <= -max && transform.position.x > -max)
		{
			float sc = player1.transform.localScale.y * 0.5f + transform.localScale.y * 0.5f;
			if (transform.position.y <= player1.transform.position.y + sc &&
				transform.position.y >= player1.transform.position.y - sc)
			direction.x = -direction.x;
			speed += 0.02f;
		}
		if (transform.position.x > 8f)
		{
			score1++;
			PrintScore();
			Reset();
		}
		else if (transform.position.x < -8f)
		{
			score2++;
			PrintScore();
			Reset();
		}
	}
}

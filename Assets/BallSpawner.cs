using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameManager gameManager;
	public Ball ball;
	public float ballStartSpeed;

	private void Start()
	{
		SpawnBall();
	}
	public void SpawnBall()
	{
		ball.transform.position = transform.position;
		ball.rb2D.velocity = new Vector2(
			gameManager.players[0].Score < gameManager.players[1].Score ? 1 : -1,
			Random.Range(-1f,1f)) * ballStartSpeed;
	}
}

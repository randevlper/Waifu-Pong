using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	[Range(0,1)]
	public int scoringPlayer;

	public BallSpawner ballSpawner;
	public GameManager gameManager;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Ball")
		{
			gameManager.players[scoringPlayer].Score++;
			ballSpawner.SpawnBall();
		}
	}
}

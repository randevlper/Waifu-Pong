using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer : MonoBehaviour {

	// Use this for initialization
	public Text scoreText;

	public void SetScore(int score)
	{
		scoreText.text = score.ToString();
	}
}

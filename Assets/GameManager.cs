using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [System.Serializable]
    public struct PlayerData
    {

        private int score;

        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                UI.SetScore(score);
                GameManager.instance.CheckIfWin();
            }
        }
        public UIPlayer UI;
    }

    static GameManager instance;


    const int numPlayers = 2;

    public int winningScore;

    [SerializeField]
    public PlayerData[] players = new PlayerData[numPlayers];

	public Text winScreen;

    private void Start()
    {
        instance = this;
        for (int i = 0; i < players.Length; i++)
        {
            players[i].Score = 0;
        }
    }

    void CheckIfWin()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].Score >= winningScore)
            {
				winScreen.text = "Player " + (i+1).ToString() + " won!";
                winScreen.gameObject.SetActive(true);
				Invoke("ReturnToMainMenu", 2);
            }
        }
    }

	void ReturnToMainMenu()
	{
		SceneManager.LoadScene(0);
	}
}

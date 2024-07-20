using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public Ball ball;
	public Paddle playerPaddle;
	public Paddle computerPaddle;
	public Text playerScoreText;
	public Text computerScoreText;
	private int _playerScore;
	private int _computerScore;
	public string winner = "";

	public void PlayerScores()
	{
		_playerScore++;
		CheckWinner();
		this.playerScoreText.text = _playerScore.ToString();
		ResetRound();
	}

	public void ComputerScores()
	{
		_computerScore++;
		CheckWinner();
		this.computerScoreText.text = _computerScore.ToString();
		ResetRound();		
	}

	private void ResetRound()
	{
		this.playerPaddle.ResetPosition();
		this.computerPaddle.ResetPosition();
		this.ball.ResetPosition();
		this.ball.AddStartingForce();
	}

	private void CheckWinner()
	{
		if (_playerScore == 11)
		{
			winner = "player";
			PauseControl.PressPause();
			Invoke("GoToMainMenu", 0.25f);

		}
		else if (_computerScore == 11)
		{
			winner = "computer";
			PauseControl.PressPause();
			Invoke("GoToMainMenu", 0.25f);
		}
	}

	private void RestartGame()
	{		
		_playerScore = 0;
		_computerScore = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	private void GoToMainMenu()
	{		
		_playerScore = 0;
		_computerScore = 0;
		SceneManager.LoadScene(1);
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private ScoreUI scoreUI;
    [SerializeField] private Ball ball;
    private int _score;

    private void Start()
    {
        _score = 0;
        ball.BallIntersectsWithGap += IncreaseScore;
        ball.BallColidedWithGoalAction += GameOver;
        Time.timeScale = 1;
    }

    private void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0; //Freeze the game
    }

    public void Replay()
    {
        SceneManager.LoadScene(Constants.GameSceneName);
    }

    private void IncreaseScore()
    {
        scoreUI.IncreaseScore(_score++);
    }
}

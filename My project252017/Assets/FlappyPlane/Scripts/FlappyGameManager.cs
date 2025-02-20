using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyGameManager : MonoBehaviour
{
    static FlappyGameManager gameManager;

    FlappyUIManager uiManager;

    public FlappyUIManager UIManager
    {
        get { return uiManager; }
    }


    public static FlappyGameManager Instance
    {
        get { return gameManager; }
    }




    private int currentScore = 0;

    private void Awake()
    {
        gameManager = this;
        uiManager = FindAnyObjectByType<FlappyUIManager>();
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
    }


    public void GameOver()
    {
        Debug.Log("Game Over");
        uiManager.SetRestart();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }

}
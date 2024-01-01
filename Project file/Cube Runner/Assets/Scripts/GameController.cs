using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPannel;
    public GameObject TabToStart;
    public GameObject ScoreText;
    private void Start()
    {
        GameOverPannel.SetActive(false);
        TabToStart.SetActive(true);
        ScoreText.SetActive(false);
        PauseGame();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        ScoreText.SetActive(false);
        GameOverPannel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        ScoreText.SetActive(true);
        TabToStart.SetActive(false);
        Time.timeScale = 1f;
    }
}

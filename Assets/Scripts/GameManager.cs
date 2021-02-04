using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject gameOverCanvas;
    [SerializeField]
    public GameObject gamePauseCanvas;

    void Start()
    {
        Time.timeScale = 1;   
    }
    
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ShowMenu()
    {
        Time.timeScale = 0;
        gamePauseCanvas.SetActive(true);
    }

    public void Resume()
    {
        gamePauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}

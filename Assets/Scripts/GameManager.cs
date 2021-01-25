using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public GameObject gameStartCanvas;
    public GameObject gameOverCanvas;

    void Start()
    {
        Time.timeScale = 0;   
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        gameStartCanvas.SetActive(false);
        Time.timeScale = 1;   
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}

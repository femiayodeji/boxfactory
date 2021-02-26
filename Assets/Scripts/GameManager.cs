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
    [SerializeField]
    public GameObject gameCreditCanvas;

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
        AdManager.Instance.HideBanner();
        AdManager.Instance.ShowInterstitialAd();
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        AdManager.Instance.ShowInterstitialAd();
        SceneManager.LoadScene(1);
    }

    public void ShowCredit()
    {
        gameCreditCanvas.SetActive(true);
    }

    public void HideCredit()
    {
        gameCreditCanvas.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ShowMenu()
    {
        AdManager.Instance.HideBanner();
        Time.timeScale = 0;
        gamePauseCanvas.SetActive(true);
    }

    public void Resume()
    {
        AdManager.Instance.ShowBanner();
        gamePauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Replay()
    {
        Play();
    }
}

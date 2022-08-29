using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    private AudioSource bgMusic;

    private void Start()
    {
        bgMusic = GameObject.Find("BgMusic").GetComponent<AudioSource>();
    }

    public void QuitTheGame()
    {
        Application.Quit();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(1);
        bgMusic.Play();
        Time.timeScale = 1.0f;
    }

    public void LoadMenuScen()
    {
        Destroy(bgMusic.gameObject);
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}

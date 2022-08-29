using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleSceneChange : MonoBehaviour
{
    public AudioSource bgmusic;

    void Awake()
    {
        DontDestroyOnLoad(bgmusic.gameObject);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

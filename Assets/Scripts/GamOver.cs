using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamOver : MonoBehaviour
{
    private  AudioSource explosionAudio;
    private  AudioSource marioDeathAudio;
    private  AudioSource bgMusic;

    public ParticleSystem boom;

    public GameObject uiCanvas;
    public GameObject gameOverCanvas;


    void Start()
    {
        explosionAudio = GameObject.Find("ExplosionAudio").GetComponent<AudioSource>();
        marioDeathAudio = GameObject.Find("DeathSound").GetComponent<AudioSource>();
        bgMusic = GameObject.Find("BgMusic").GetComponent<AudioSource>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void GameOverNormal()
    {
        Invoke(nameof(DoGameOverStuff), 1f);
        bgMusic.Stop();
        explosionAudio.Play();
        boom.Play();
        Handheld.Vibrate();
    }

    public void GameOverReversed()
    {
        Invoke(nameof(DoGameOverStuff), 2f);
        bgMusic.Stop();
        marioDeathAudio.Play();
    }

    public void DoGameOverStuff()
    {
        Time.timeScale = 0f;
        uiCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
    }
}

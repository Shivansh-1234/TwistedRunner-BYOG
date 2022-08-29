using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    private float timer;
    [HideInInspector] public static float roundedTimer;

    public TextMeshProUGUI timerText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        roundedTimer = Mathf.RoundToInt(timer);
        timerText.text = roundedTimer.ToString();
    }
}

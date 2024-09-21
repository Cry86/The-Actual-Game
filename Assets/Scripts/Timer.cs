using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Import SceneManager

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeRemaining = 120f; // Start at 2 minutes
    private bool timerIsRunning = true;

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                UpdateTimerDisplay(timeRemaining);
                LoadGameOverScene(); // Load "You Died" scene
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        // Convert timeToDisplay to minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Display the time in MM:SS format
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LoadGameOverScene()
    {
        // Load the scene that shows "You Died"
        SceneManager.LoadScene("GameOver");
    }
}
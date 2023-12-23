using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private Animator pauseAnimator;

    private bool isPaused = false;

    private void Awake()
    {
        pauseScreen.SetActive(isPaused);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pauseScreen.SetActive(isPaused);
            if (isPaused)
            {
                Time.timeScale = 0f;
                pauseAnimator.SetTrigger("FadeIn");
            }
            else
            {
                Time.timeScale = 1.0f;
            }
        }
    }

    public void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        pauseScreen.SetActive(false);
    }
}

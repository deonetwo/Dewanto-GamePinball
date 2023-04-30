using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button PlayButton;
    public Button CreditsButton;
    public Button ExitButton;

    private void Start()
    {
        PlayButton.onClick.AddListener(PlayGame);
        CreditsButton.onClick.AddListener(Credits);
        ExitButton.onClick.AddListener(ExitGame);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

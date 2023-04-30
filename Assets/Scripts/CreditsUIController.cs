using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditsUIController : MonoBehaviour
{
    public Button BackButton;

    private void Start()
    {
        BackButton.onClick.AddListener(MainMenu);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

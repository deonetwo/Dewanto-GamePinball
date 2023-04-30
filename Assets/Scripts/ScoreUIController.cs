using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUIController : MonoBehaviour
{
    public TMP_Text ScoreText;

    public ScoreManager ScoreManager;

    private void Update()
    {
        ScoreText.text = ScoreManager.Score.ToString();
    }
}

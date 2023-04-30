using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float Score;

    private void Start()
    {
        ResetScore();
    }

    public void AddScore(float addition)
    {
        Score += addition;
    }

    public void ResetScore()
    {
        Score = 0;
    }
}

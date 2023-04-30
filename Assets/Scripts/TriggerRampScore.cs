using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampScore : MonoBehaviour
{
    public Collider Ball;
    public float Score;

    public ScoreManager ScoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            ScoreManager.AddScore(Score);
        }
    }
}

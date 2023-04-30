using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider Ball;
    public GameObject GameOverCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other == Ball)
        {
            GameOverCanvas.SetActive(true);
            Ball.gameObject.SetActive(false);
        }
    }
}

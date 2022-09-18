using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D ()
    {
        gameManager.CompleteLevel();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

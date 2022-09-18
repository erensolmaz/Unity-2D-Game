using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public float restartDelay = 1f;


    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame ()

    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Restart();
            Invoke("Restart", 2f);
        }
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

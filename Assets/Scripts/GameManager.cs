using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public float restartDelay=2f;
    public GameObject winningUI;
    public void Win()
    {
        winningUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Invoke(nameof(Restart),restartDelay);
        }
    }

    private void Restart()
    {
        gameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

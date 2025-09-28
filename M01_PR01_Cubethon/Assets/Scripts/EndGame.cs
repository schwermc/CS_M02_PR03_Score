using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private float restartDelay = 2f;
    private AudioEndGame audioEndGame;

    void Start()
    {
        audioEndGame = gameObject.AddComponent<AudioEndGame>();
    }

    public void endTheGame()
    {
        Debug.Log("Game Over");
        audioEndGame.playSound();
        Invoke("Restart", restartDelay);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

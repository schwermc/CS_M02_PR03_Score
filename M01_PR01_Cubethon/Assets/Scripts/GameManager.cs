using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    bool gameEnded = false;

    private EndGame endGame;
    private ChangeColor changeColor;
    private ChangeShape changeShape;

    void Start()
    {
        endGame = gameObject.AddComponent<EndGame>();
        changeColor = gameObject.AddComponent<ChangeColor>();
        changeShape = gameObject.AddComponent<ChangeShape>();
    }

    public void CompleteLevel()
    {
        Debug.Log("Level Won");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            endGame.endTheGame();
            changeColor.colorChange();
            changeShape.sizeChange();
        }
    }
}

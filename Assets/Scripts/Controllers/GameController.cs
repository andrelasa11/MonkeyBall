using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Attributes")]
    public int score;

    [Header("Dependencies")]
    [SerializeField] private ScoreIndicatorUI scoreIndicatorUI;

    private void Awake()
    {
        scoreIndicatorUI.SetScoreValue(score);
    }

    public void SetScore()
    {
        score += 200;

        scoreIndicatorUI.SetScoreValue(score);

    }

}

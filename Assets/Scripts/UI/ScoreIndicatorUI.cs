using UnityEngine;
using UnityEngine.UI;

public class ScoreIndicatorUI : MonoBehaviour
{
    [Header("Dependencies")]
    public Text scoreValue;

    public void SetScoreValue(int score)
    {
        scoreValue.text = score.ToString();
    }
}

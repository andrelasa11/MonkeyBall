using UnityEngine;
using UnityEngine.UI;

public class ShootIndicatorUI : MonoBehaviour
{
    [Header("Dependencies")]
    public Image ballImage;
    public Text numberOfBallsText;

    public void SetImageNText(Sprite _ballImage, int numberOfBalls)
    {
        ballImage.sprite = _ballImage;
        numberOfBallsText.text = numberOfBalls.ToString();
    }
}

using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterDo : MonoBehaviour
{
    [SerializeField] private UnityEvent regularBallActions;
    [SerializeField] private UnityEvent fireBallActions;
    [SerializeField] private UnityEvent targetActions;
    [SerializeField] private UnityEvent goalkeeperActions;
    [SerializeField] private UnityEvent defenderActions;
    [SerializeField] private UnityEvent otherActions;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("regularBall"))
        {
            regularBallActions.Invoke();
        }        
        else if (collision.CompareTag("fireBall"))
        {
            fireBallActions.Invoke();
        }
        else if (collision.CompareTag("target"))
        {
            targetActions.Invoke();
        }
        else if (collision.CompareTag("goalkeeper"))
        {
            goalkeeperActions.Invoke();
        }
        else if (collision.CompareTag("defender"))
        {
            defenderActions.Invoke();
        }
        else
        {
            otherActions.Invoke();
        }

    }
}

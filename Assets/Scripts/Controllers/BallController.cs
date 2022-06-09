using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [Header("Configuration")]
    public float speed;

    [Header("Dependencies")]
    [SerializeField] private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.velocity = (Vector2.up * speed);
    }

    public void StopMovement()
    {
        rigidBody.velocity = Vector2.zero;
    }

    public void PlayMissSound()
    {
        AudioController.Instance.playMiss();
    }

    public void PlayFireSound()
    {
        AudioController.Instance.playFire();
    }

}

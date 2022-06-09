using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    [Header("Configuration")]
    [SerializeField] private float destroyTime;

    [Header("Dependencies")]
    public Shooter shooter;

    public void DestroyThis()
    {
        Destroy(gameObject, destroyTime);
    }

    public void InstaDestroyThis()
    {
        Destroy(gameObject, 0);
    }
}
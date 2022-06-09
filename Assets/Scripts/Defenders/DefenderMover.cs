using System.Collections;
using UnityEngine;

public class DefenderMover : MonoBehaviour
{

    [Header("Configuration")]
    [SerializeField] private float speed;
    [SerializeField] private float waitTime;

    //private
    private Vector3 direction;

    private void Start()
    {
        StartCoroutine(EvasiveManuever());
    }

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

    private IEnumerator EvasiveManuever()
    {

        while (true)
        {
            direction = new Vector3(-1, 0, 0);

            yield return new WaitForSeconds(waitTime);

            direction = new Vector3(1, 0, 0);

            yield return new WaitForSeconds(waitTime);
        }


    }

}

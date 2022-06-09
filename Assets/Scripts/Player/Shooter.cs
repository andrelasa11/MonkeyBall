using UnityEngine;
using System.Collections.Generic;

public class Shooter : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private float fireRate;
    public int numberOfBalls;

    [Header("Dependencies")]
    [SerializeField] private Transform shootOrigin;
    [SerializeField] private GameController gameController;
    [SerializeField] private ShootIndicatorUI shootIndicatorUI;
    [SerializeField] private List<GameObject> shootPrefabs;

    //private
    private float nextShoot;
    private int nextShootIndex;

    private void Start()
    {
        RandomNextShootIndex();
        shootIndicatorUI.SetImageNText(shootPrefabs[nextShootIndex].GetComponentInChildren<SpriteRenderer>().sprite, numberOfBalls);

        
    }

    public void DoShoot()
    {
        if(Time.time > nextShoot && numberOfBalls > 0)
        {
            AudioController.Instance.playKick();

            nextShoot = Time.time + fireRate;
            Instantiate(shootPrefabs[nextShootIndex], shootOrigin.position, shootOrigin.rotation);

            RandomNextShootIndex();

            numberOfBalls--;

            shootIndicatorUI.SetImageNText(shootPrefabs[nextShootIndex].GetComponentInChildren<SpriteRenderer>().sprite, numberOfBalls);

        }
        
    }

    public void RandomNextShootIndex()
    {
        nextShootIndex = Random.Range(0, shootPrefabs.Count);
    }
}

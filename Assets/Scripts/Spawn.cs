using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] baloons;
    [SerializeField] private float TimeSpawn;
    [SerializeField] private GameObject SpawnPointLeft;
    [SerializeField] private GameObject SpawnPointRight;

    private void Start()
    {
        
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        for (int i = 0; i < baloons.Length; i++)
        {
            var ind = Random.Range(0, baloons.Length);
           

            for (int y = 0; y < 1; y++)
            {
                float spawnY = -10f;

                float spawnX = Random.Range(SpawnPointLeft.transform.position.x, SpawnPointRight.transform.position.x);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);

                yield return new WaitForSeconds(TimeSpawn);

                Instantiate(baloons[ind], spawnPosition, Quaternion.identity);
            }
        }
        Repeat();
    }
   
}

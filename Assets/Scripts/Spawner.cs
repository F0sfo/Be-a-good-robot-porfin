using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject[] bombs;

    public float xBounds, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        int randomFruit = Random.Range(0, fruits.Length);

        int randomBombs = Random.Range(0, bombs.Length);

        if (Random.value <= .6f)
            Instantiate(fruits[randomFruit],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

        else
            Instantiate(bombs[randomBombs],
                new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

        StartCoroutine(SpawnRandomGameObject());
    }
}

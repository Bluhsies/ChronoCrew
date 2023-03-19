using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{

    public Transform[] spawnPoints; // Allows empty game objects to be used as spawn points on the map, added to a list to be chosen at random in the inspector.
    public GameObject[] items; // Items which are to be spawned in an array and can be added via the inspector. Although there is currently only 1 item, more can be added to the array.
    int randomSpawnPoint;
    int randomItem;
    public static bool spawnAllowed; // Checks whether an item can be spawned, which is always true.

    void Start()
    {
        spawnAllowed = true; // The value of the boolean spawnAllowed is set to true here.
        InvokeRepeating("SpawnItem", 0f, 5f); // This will determine the time between each item being spawned. Currently set to 5 seconds.
    }

    void SpawnItem()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length); // Will determine which spawn point is used, using Random.Range which will take a value from the spawnPoints array.
            randomItem = Random.Range(0, items.Length); // Will determine which item is used, using Random.Range which will take a value from the items array.
            Instantiate(items[randomItem], spawnPoints[randomSpawnPoint].position, Quaternion.identity); // This will spawn the random item at a random spawn point.
        }
    }
}

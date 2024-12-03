using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ConveyorBeltSpawn : MonoBehaviour
{
    public GameObject collectable;

    public Transform upperSpawnLimit;
    public Transform lowerSpawnLimit;

    public float spawnRate;
    float spawnDelay;
    Vector3 spawnPos;
    //conveyor belt that spawns items in the item list at random intervals

    //the spawned objects will follow the direction of the conveyor belt
    //objects need to destroy offscreen but not based on time.
    // Start is called before the first frame update
    //objects are spawned on a modifyable time frame.
    protected virtual void Update()
    {
        //spawn objects on a modifiable time frame
        spawnConditionals();

    }

    protected virtual void spawnConditionals()
    {
        spawnDelay++;
        print(spawnDelay * Time.deltaTime);
        if (spawnDelay * Time.deltaTime >= spawnRate)
        {
            spawnObjects();
            spawnDelay = 0;
        }
    }

    protected virtual void spawnObjects()
    {
        float scalar = Random.Range(0.1f, 0.9f);
        print(scalar);
        //they need to spawn within a set height of the conveyor belt.\
        float distX = upperSpawnLimit.position.x - lowerSpawnLimit.position.x;
        float distY = upperSpawnLimit.position.y - lowerSpawnLimit.position.y;

        float modX = (distX * scalar) + lowerSpawnLimit.position.x;
        float modY = (distY * scalar) + lowerSpawnLimit.position.y;

        spawnPos = new Vector3(modX, modY, 0);

        Instantiate(collectable,spawnPos, Quaternion.identity);
    }
}

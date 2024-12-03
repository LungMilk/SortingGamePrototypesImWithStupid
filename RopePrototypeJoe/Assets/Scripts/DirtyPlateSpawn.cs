using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyPlateSpawn : ConveyorBeltSpawn
{
    public float plateLimit;
    public float platesInRotation = 0;
    // Start is called before the first frame update
    protected override void Update()
    {
        if(platesInRotation < plateLimit)
            base.spawnConditionals();
    }

    protected override void spawnObjects()
    {
        //make the spawner an organized base class so objects can be spawned.
        base.spawnObjects();
        platesInRotation++;
    }

    
}

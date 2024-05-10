using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesCounter : BaseCounter
{
    private KitchenObjectSO plateKitchenObjectSO;

    private float spawnPLateTimer;
    private float spawnPlateTimerMax = 4f;

    private void Update()
    {
        spawnPLateTimer += Time.deltaTime;

        if (spawnPLateTimer > spawnPlateTimerMax)
        {
            KitchenObject.SpawnKitchenObject(plateKitchenObjectSO, this);
        }
    }
}

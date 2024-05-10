using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatesCounter : BaseCounter
{
    [SerializeField]
    private KitchenObjectSO plateKitchenObjectSO;

    private float spawnPLateTimer;
    private float spawnPlateTimerMax = 4f;
    private int platesSpawnedAmount;
    private int platesSpawnedAmountMax;

    private void Update()
    {
        spawnPLateTimer += Time.deltaTime;

        if (spawnPLateTimer > spawnPlateTimerMax)
        {
            spawnPLateTimer = 0f;

            if (platesSpawnedAmount<platesSpawnedAmountMax)
            {
                platesSpawnedAmount++;
            }
        }
    }
}

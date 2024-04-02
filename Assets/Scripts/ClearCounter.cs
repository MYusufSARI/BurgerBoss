using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField]
    private KitchenObjectSO kitchenObjectSO;


    public override void Interact(Player player)        
    {
        if (!HasKitchenObject())
        {
            //There is no KitchenObject here
        }
        else
        {
            //There is a KitchenObject here
        }
    }
}

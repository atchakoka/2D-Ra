//Kopiert fra YouTube, vet ikke helt hvordan scripten fungerer.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class InventoryItem
{
    public ItemData itemData;
    public int stackSize;

    public InventoryItem(ItemData item) //Bestemmer hva objektet skal hete og æker verdien stackSize
    {
        itemData = item;
        AddToStack();
    }

    public void AddToStack() //Øker variablen stackSize
    {
        stackSize++;
    }

    public void RemoveFromStack() //Minsker variablen stackSize
    {
        stackSize--;
    }
}

//Kopiert fra YouTube, vet ikke helt hvordan scripten fungerer.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //InventoryItem er en egen script som er en type klasse. Denne holder verdier for ulike items.
    public List<InventoryItem> inventory = new List<InventoryItem>();
    private Dictionary<ItemData, InventoryItem> itemDictionary = new Dictionary<ItemData, InventoryItem>();
    //Sjekker om typen item finnes, hvis ja øker den stackSiza og hvis nei lager den et nytt item. Dictionaryen har klassene ItemData og InventoryItem.

    public void Add(ItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out InventoryItem item)) //Sjekker om itemet finnes
        {
            item.AddToStack();
        }
        else //Kommandoer for hvis man  må lages et nytt item.
        {
            InventoryItem newItem = new InventoryItem(itemData);//Lager et nytt inventoryitem
            inventory.Add(newItem);//Lagrer det i listen
            itemDictionary.Add(itemData, newItem);//Lagrer det i dictionaryen
        }
    }

    public void Remove(ItemData itemData)
    {
        if(itemDictionary.TryGetValue(itemData, out InventoryItem item))//Sjekker om itemet finnes
        {
            item.RemoveFromStack();
            if(item.stackSize == 0)//Hvis det ikke lenger finnes et item fjernes den fra listen og dictionaryen
            {
                inventory.Remove(item);
                itemDictionary.Remove(itemData);
            }
        }
    }
}

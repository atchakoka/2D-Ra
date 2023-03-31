using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenInventory : MonoBehaviour
{
    [SerializeField] private GameObject uiElement;
    public bool InventorySwitch=false;

    // Start is called before the first frame update
    void Start()
    {
        uiElement.SetActive(InventorySwitch);
        InventorySwitch=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(gameObject.GetComponent<OpenMainMenu>().MainMenuSwitch==true){
                uiElement.SetActive(InventorySwitch);
                if(InventorySwitch==true) {InventorySwitch=false;}
                else {InventorySwitch=true;}
            }
            
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    ItemScript item;
    public Image Icon;
    
    public Image ItemInfo;
    private Text[] InfoText;

    public bool infoclicked;

   // private string name;
   // private string itemdescription;

     public void AddItem(ItemScript newItem)
     {
         item = newItem;
         Icon.sprite = item.Image;
         Icon.enabled = true;

        InfoText = ItemInfo.GetComponentsInChildren<Text>();

        //name = item.name;
        //itemdescription = item.Description;

        InfoText[0].text = "Name:";
        InfoText[1].text = "Description: ";
     }

     public void ClearSlot()
     {
         item = null;
         Icon.sprite = null;
         Icon.enabled = false;
         
     }

     public void OnRemoveButton()
     {
         Inventory.Instance.RemoveItems(item);
     }

    public void UseItem()
    {
        // dont know what to add here yet
    }

    public void OnInfoClicked()
    {
        infoclicked = !infoclicked;
        InfoText = ItemInfo.GetComponentsInChildren<Text>();

        if (infoclicked)
        {
            ItemInfo.gameObject.SetActive(true);

            InfoText[0].text = "Name: " + item.ItemName;
            InfoText[1].text = "Description: " + item.Description;

            InfoText[0].enabled = true;
            InfoText[1].enabled = true;
        }
        else if(!infoclicked)
        {
            ItemInfo.gameObject.SetActive(false);

            InfoText[0].enabled = false;
            InfoText[1].enabled = false;
        }
    }

}

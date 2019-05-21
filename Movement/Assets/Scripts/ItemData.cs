using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static  class ItemData
{
    public static Item CreateItem(int ItemID)
    {
        string name = "";
        int value = 0;
        string description = "";
        string icon = "";
        string mesh = "";
        ItemType type = ItemType.Food;
        int heal = 0;
        int damage = 0;
        int armour = 0;
        int amount = 0;

        switch (ItemID)
        {
            #region Food 0-99
            case 0:
                name = "Apple";
                value = 5;
                description = "Munchy and Crunchy";
                icon = "Food/Apple_Icon";
                mesh = "Food/Apple_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;

            case 1:
                name = "Barrel";
                value = 5;
                description = "Woody";
                icon = "Food/Barrel_Icon";
                mesh = "Food/Barrel_Mesh";
                type = ItemType.Food;
                heal = 10;
                amount = 1;
                break;
            case 2:
                name = "Bucket";
                value = 5;
                description = "of water";
                icon = "Food/Bucket_Icon";
                mesh = "Food/Bucket_Mesh";
                type = ItemType.Food;
                heal = 20;
                amount = 1;
                break;
                #endregion
                #region Weapon 100-199
                #endregion
                #region Apparel 200-299
                #endregion
                #region Crafting 300-399
                #endregion
                #region Quests 400-499
                #endregion
                #region Ingredients 500-599
                #endregion
                #region Potions 600-699
                #endregion
                #region Scrolls 700-799
                #endregion
        }
        Item temp = new Item
        {
            Name = name,
            Descripton = description,
            ID = ItemID,
            Value = value,
            Damage = damage,
            Armour = armour,
            Amount = amount,
            Heal = heal,
            Type = type,
            Mesh = Resources.Load("Prefabs/" + mesh) as GameObject,
            Icon = Resources.Load("Icon/" + icon) as Texture2D
        };
        return temp;
    }
}
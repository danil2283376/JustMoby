using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodItem", menuName = "ItemsSO/FoodItem")]
public class FoodItemSO : ItemSO
{
    public override ItemSO GetTypeItem()
    {
        return this;
    }

    public override TypeItem GetTypeEnum()
    {
        return TypeItem.Food;
    }

    public override Type GetTypeItemUIPack()
    {
        return typeof(ItemUIFoodItem);
    }
}

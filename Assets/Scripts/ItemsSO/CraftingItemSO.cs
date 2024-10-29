using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CraftingItem", menuName = "ItemsSO/CraftingItem")]
public class CraftingItemSO : ItemSO
{
    public override ItemSO GetTypeItem()
    {
        return this;
    }

    public override TypeItem GetTypeEnum()
    {
        return TypeItem.CraftingMaterial;
    }

    public override Type GetTypeItemUIPack()
    {
        return typeof(ItemUICraftingItem);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ToolItem", menuName = "ItemsSO/ToolItem")]
public class ToolItemSO : ItemSO
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
        return typeof(ItemUIToolItem);
    }
}
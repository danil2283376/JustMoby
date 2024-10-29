using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPackUI : DataUI
{
    public string TextHeader;
    public string TextDiscription;
    public Sprite SpritePack;
    public List<ItemPack> Items;
    public int CountMaxItems;
    public TypeView typeView;
    public bool DiscountExist;
    public float OriginalPrice;
    public float DiscountPercent;
    public float DiscountPrice;


    public override DataUI GetDataForUI()
    {
        return this;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIPackSO : ScriptableObject
{
    public string TextHeader;
    public string TextDiscription;
    public float PriceUSD;
    public bool Discounting = false;
    [Range(0, 100)]
    public int DiscountPercent = 0;
    public Sprite spritePack;
    public TypeView typeView = TypeView.NameCount;

    [Range(3, 6)]
    public int CountItemView = 3;

    public List<ItemPack> itemPacks = new List<ItemPack>();

    public abstract UIPackSO GetTypeItem();

    public abstract TypePack GetTypeEnum();
}

public enum TypePack
{
    StarterPack = 1,
}

public enum TypeView 
{
    NameCount = 1,
    Name = 2,
    Count = 3
}

[Serializable]
public struct ItemPack 
{
    public ItemSO Item;
    public int Count;
}
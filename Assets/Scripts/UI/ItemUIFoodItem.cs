using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUIFoodItem : ItemUIPack
{
    private LinksForItem _linksForItem;

    private FoodItemSO _foodItemSO;

    public override void Init(ItemPack itemPack, TypeView typeView)
    {
        _linksForItem = GetComponent<LinksForItem>();

        _foodItemSO = itemPack.Item as FoodItemSO;

        _linksForItem.ImageItem.sprite = _foodItemSO.spriteItem;
        _linksForItem.TextName.text = _foodItemSO.NameItem;
        _linksForItem.TextCount.text = "x" + itemPack.Count;

        if (typeView == TypeView.Count)
            _linksForItem.TextName.gameObject.SetActive(false);
        else if (typeView == TypeView.Name)
            _linksForItem.TextCount.gameObject.SetActive(false);
    }
}

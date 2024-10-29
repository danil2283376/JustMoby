using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUICraftingItem : ItemUIPack
{
    private LinksForItem _linksForItem;

    private CraftingItemSO _craftingItemSO;

    public override void Init(ItemPack itemPack, TypeView typeView)
    {
        _linksForItem = GetComponent<LinksForItem>();

        _craftingItemSO = itemPack.Item as CraftingItemSO;

        _linksForItem.ImageItem.sprite = _craftingItemSO.spriteItem;
        _linksForItem.TextName.text = _craftingItemSO.NameItem;
        _linksForItem.TextCount.text = "x" + itemPack.Count;

        if (typeView == TypeView.Count)
            _linksForItem.TextName.gameObject.SetActive(false);
        else if (typeView == TypeView.Name)
            _linksForItem.TextCount.gameObject.SetActive(false);
    }
}

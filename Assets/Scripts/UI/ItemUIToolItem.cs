using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUIToolItem : ItemUIPack
{
    private LinksForItem _linksForItem;

    private ToolItemSO _toolItemSO;

    public override void Init(ItemPack itemPack, TypeView typeView)
    {
        _linksForItem = GetComponent<LinksForItem>();

        _toolItemSO = itemPack.Item as ToolItemSO;

        _linksForItem.ImageItem.sprite = _toolItemSO.spriteItem;
        _linksForItem.TextName.text = _toolItemSO.NameItem;
        _linksForItem.TextCount.text = "x" + itemPack.Count;

        if (typeView == TypeView.Count)
            _linksForItem.TextName.gameObject.SetActive(false);
        else if (typeView == TypeView.Name)
            _linksForItem.TextCount.gameObject.SetActive(false);
    }
}

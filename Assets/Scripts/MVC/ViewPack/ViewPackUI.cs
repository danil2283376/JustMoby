using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ViewPackUI : View
{
    public TMP_Text HeaderText;
    public TMP_Text DiscriptionText;
    public GameObject ParentItems;
    public GameObject PrefabItem;
    public Image ImagePack;
    public PriceUIHandler PriceUIHandler;

    public GameObject WindowCountItems;
    public GameObject WindowPanelPack;

    public GameObject BuyWindow;

    private DataPackUI _datasUIPack;

    public override void Init(DataUI datasUIPack)
    {
        _datasUIPack = datasUIPack as DataPackUI;

        HeaderText.text = _datasUIPack.TextHeader;
        DiscriptionText.text = _datasUIPack.TextDiscription;
        ImagePack.sprite = _datasUIPack.SpritePack;

        for (int i = 0; i < _datasUIPack.CountMaxItems; i++)
        {
            GameObject item = Instantiate(PrefabItem, ParentItems.transform);
            ItemUIPack itemUIPack = (ItemUIPack)item.AddComponent(_datasUIPack.Items[i].Item.GetTypeItemUIPack());
            itemUIPack.Init(_datasUIPack.Items[i], _datasUIPack.typeView);
        }
        PriceValues priceValues = new PriceValues(_datasUIPack.DiscountExist, _datasUIPack.OriginalPrice, _datasUIPack.DiscountPercent, _datasUIPack.DiscountPrice);
        PriceUIHandler.Init(priceValues);
    }

    public override void OpenMainWindow() 
    {
        WindowCountItems.SetActive(false);
        WindowPanelPack.SetActive(true);
    }

    public override void OpenBuyWindow() 
    {
        foreach (Transform child in ParentItems.transform)
        {
            Destroy(child.gameObject);
        }
        WindowPanelPack.SetActive(false);
        BuyWindow.SetActive(true);
    }

    public override void CloseBuyWindow() 
    {
        BuyWindow.SetActive(false);
        WindowCountItems.SetActive(true);
    }
}

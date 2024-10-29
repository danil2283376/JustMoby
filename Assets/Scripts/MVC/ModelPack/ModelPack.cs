using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class ModelPack : Model
{
    private UIPackSO _starterPackSO;
    private List<ItemSO> _items;
    private readonly string _resourcePathItems = "SOItems";
    private readonly string _resourcePathUIPack = "SOUIPack";
    private bool _init = false;
    private ModelDataPack _modelDataPack;
    private bool _dataExist;

    public override void Init()
    {
        GetData();
        _init = true;
    }

    public override DataUI GetItemsForUI(ModelData modelData)
    {
        _modelDataPack = modelData as ModelDataPack;

        if (_init == false)
        {
            Init();

            _init = true;
        }

        return SetDataForUI(_modelDataPack);
    }

    public override bool Purchasing()
    {
        if (_starterPackSO.Discounting)
        {
            float discount = CalculateDiscount();
            Debug.Log("Purchase at a discount: " + "$" + discount + "!");
        }
        else
        {
            Debug.Log("Purchase without discount: " + "$" + _starterPackSO.PriceUSD + "!");
        }
        return true;
    }

    private DataPackUI SetDataForUI(ModelDataPack modelDataPack)
    {
        DataPackUI data = new DataPackUI();
        data.TextHeader = _starterPackSO.TextHeader;
        data.TextDiscription = _starterPackSO.TextDiscription;
        data.SpritePack = _starterPackSO.spritePack;

        data.CountMaxItems = ValidateMaxItem(modelDataPack.MaxItems);

        data.typeView = _starterPackSO.typeView;

        data.DiscountExist = _starterPackSO.Discounting;
        data.OriginalPrice = ValidatePriceUSD(_starterPackSO.PriceUSD);
        data.DiscountPercent = _starterPackSO.DiscountPercent;
        data.DiscountPrice = CalculateDiscount();

        data.Items = new List<ItemPack>();
        for (int i = 0; i < _starterPackSO.itemPacks.Count; i++) 
        {
            data.Items.Add(_starterPackSO.itemPacks[i]);
        }

        return data;
    }

    private void GetData() 
    {
        if (_dataExist == false)
        {
            _starterPackSO = Resources.LoadAll<UIPackSO>(_resourcePathUIPack)
                .Where(x => x.GetTypeEnum() == TypePack.StarterPack)
                    .First();
            _items = Resources.LoadAll<ItemSO>(_resourcePathItems).ToList();
            _dataExist = true;
        }
    }

    private float CalculateDiscount() 
    {
        float price = _starterPackSO.PriceUSD;
        float discountPercentage = _starterPackSO.DiscountPercent;

        float discountAmount = price * (discountPercentage / 100f);
        float result = price - discountAmount;
        return result;
    }

    private int ValidateMaxItem(int maxItem)
    {
        if (maxItem >= 3 && maxItem <= 6)
            return maxItem;
        else
            return _starterPackSO.CountItemView;
    }

    private float ValidatePriceUSD(float value) 
    {
        if (value <= 0)
            return 0;
        return value;
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiscountPriceUI : PriceUI
{
    public TMP_Text TextDiscount;
    public TMP_Text TextOriginalPrice;
    public TMP_Text TextDiscountPercent;

    private PriceUIHandler _priceUIHandler; 
    public override void InitPrice(PriceUIHandler priceUIHandler, PriceValues priceValues)
    {
        _priceUIHandler = priceUIHandler;
        TextDiscount.text = "$" + _priceUIHandler.ConvertingFloatToString(priceValues.DiscountPrice.ToString(), 3);
        TextOriginalPrice.text = "$" + _priceUIHandler.ConvertingFloatToString(priceValues.OriginalPrice.ToString(), 3);
        TextDiscountPercent.text = "-" + priceValues.Discount + "%";
    }
}

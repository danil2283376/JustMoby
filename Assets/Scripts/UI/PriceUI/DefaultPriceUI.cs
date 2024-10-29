using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DefaultPriceUI : PriceUI
{
    public TMP_Text TextDiscount;

    private PriceUIHandler _priceUIHandler;
    public override void InitPrice(PriceUIHandler priceUIHandler, PriceValues priceValues)
    {
        _priceUIHandler = priceUIHandler;

        TextDiscount.text = "$" + _priceUIHandler.ConvertingFloatToString(priceValues.OriginalPrice.ToString(), 3);
    }
}

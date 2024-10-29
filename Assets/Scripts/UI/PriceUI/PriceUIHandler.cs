using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceUIHandler : MonoBehaviour
{
    public PriceUI DiscountPriceUI;
    public PriceUI DefaultPriceUI;

    public void Init(PriceValues priceValues)
    {
        if (priceValues.DiscountExist)
        {
            DiscountPriceUI.gameObject.SetActive(true);
            DefaultPriceUI.gameObject.SetActive(false);
            DiscountPriceUI.InitPrice(this, priceValues);
        }
        else
        {
            DiscountPriceUI.gameObject.SetActive(false);
            DefaultPriceUI.gameObject.SetActive(true);
            DefaultPriceUI.InitPrice(this, priceValues);
        }
    }

    //convert up to 2 decimal places
    public string ConvertingFloatToString(string value, int decimals) 
    {
        string floatString = value.ToString();
        int dotIndex = floatString.IndexOf('.');
        int commaIndex = floatString.IndexOf(',');

        int separatorIndex = dotIndex != -1 ? dotIndex : commaIndex;

        if (separatorIndex != -1 && floatString.Length >= separatorIndex + decimals)
        {
            string limitedFloatString = floatString.Substring(0, separatorIndex + decimals);
            return limitedFloatString;
        }
        else
        {
            return floatString;
        }
    }
}
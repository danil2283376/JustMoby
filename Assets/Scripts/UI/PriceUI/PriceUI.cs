using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PriceUI : MonoBehaviour
{
    public abstract void InitPrice(PriceUIHandler priceUIHandler, PriceValues priceValues);
}

public struct PriceValues
{
    public bool DiscountExist;
    public float OriginalPrice;
    public float Discount;
    public float DiscountPrice;

    public PriceValues(bool discountExist, float originalPrice, float discount, float discountPrice)
    {
        DiscountExist = discountExist;
        OriginalPrice = originalPrice;
        Discount = discount;
        DiscountPrice = discountPrice;
    }
}
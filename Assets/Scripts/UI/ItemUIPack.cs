using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class ItemUIPack : MonoBehaviour
{
    public abstract void Init(ItemPack itemPack,TypeView typeView);
}

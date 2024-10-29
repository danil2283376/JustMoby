using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    public abstract void Init(DataUI datasUIPack);

    public abstract void OpenMainWindow();

    public abstract void OpenBuyWindow();

    public abstract void CloseBuyWindow();
}

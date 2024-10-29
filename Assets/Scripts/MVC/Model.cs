using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Model
{
    public abstract void Init();

    public abstract DataUI GetItemsForUI(ModelData modelData);

    public abstract bool Purchasing();
}

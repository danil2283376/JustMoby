using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StarterPack", menuName = "UIPacks/StarterPack")]
public class StarterPackSO : UIPackSO
{
    public override UIPackSO GetTypeItem()
    {
        return this;
    }

    public override TypePack GetTypeEnum()
    {
        return TypePack.StarterPack;
    }

}

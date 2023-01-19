using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftTriggerLogic : TriggerEnter
{
    public override void TriggerEnterLogic()
    {
        DependencyManager.OnShootToGiftBox(20);
        gameObject.SetActive(false);
    }
}

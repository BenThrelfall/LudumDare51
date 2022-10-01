using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class IncreaseFireRateCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.baseFireRate += amount;
    }
}


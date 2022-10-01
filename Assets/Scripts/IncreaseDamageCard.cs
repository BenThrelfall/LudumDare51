using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class IncreaseDamageCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.baseProjectileDamage += amount;
    }
}

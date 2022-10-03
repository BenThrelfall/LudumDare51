using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class IncreaseHealthRegenCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.healthRegen += amount;
    }
}

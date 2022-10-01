using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class IncreaseProjectileSpeedCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.baseProjectileSpeed += amount;
    }
}

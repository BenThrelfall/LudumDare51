using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]

public class TakeDamageCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.playerHealth.TakeDamage(amount);
    }
}

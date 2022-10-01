using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ChangeEnemyAttackCooldownCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.baseEnemyAttackCooldown += amount;
    }
}
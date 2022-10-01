using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class ChangeEnemyMoveSpeedCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.baseEnemyMoveSpeed += amount;
    }
}
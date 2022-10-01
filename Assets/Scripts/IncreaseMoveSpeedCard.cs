using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class IncreaseMoveSpeedCard : AbilityCard {

    public float amount;

    public override void DoAbility() {
        GlobalPlayer.instance.playerMoveSpeed += amount;
    }
}

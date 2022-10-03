using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IncreasePierceCard : AbilityCard {

    public int amount;

    public override void DoAbility() {
        GlobalPlayer.instance.baseProjectilePierce += amount;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class SetBlessedCard : AbilityCard {

    public override void DoAbility() {
        GlobalPlayer.instance.playerHealth.blessed = true;
    }
}

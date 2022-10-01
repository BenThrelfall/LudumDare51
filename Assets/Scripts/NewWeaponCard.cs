using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]

public class NewWeaponCard : AbilityCard {

    public GameObject weapon;

    public override void DoAbility() {
        GlobalPlayer.instance.AddWeapon(weapon);
    }
}


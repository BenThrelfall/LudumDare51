using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]

public class ComboCard : AbilityCard {

    public List<AbilityCard> cards = new List<AbilityCard>();

    public override void DoAbility() {
        foreach (var card in cards) {
            card.DoAbility();
        }
    }
}

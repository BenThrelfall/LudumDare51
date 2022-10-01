using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class IncreaseHealthCard : AbilityCard {

    public float currentHealthGain;
    public float maxHealthGain;

    public override void DoAbility() {
        GlobalPlayer.instance.playerHealth.GetHealed(currentHealthGain);
        GlobalPlayer.instance.playerHealth.maxHealth += maxHealthGain;
    }
}

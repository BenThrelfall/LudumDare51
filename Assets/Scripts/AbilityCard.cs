using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityCard : ScriptableObject {

    public string cardName;
    public Sprite cardArt;

    public abstract void DoAbility();

}

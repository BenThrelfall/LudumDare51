using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityCard : ScriptableObject {

    public string cardName;
    [Multiline]
    public string cardDescription;
    public Sprite cardArt;

    public abstract void DoAbility();

}

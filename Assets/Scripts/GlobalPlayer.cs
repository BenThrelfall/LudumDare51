using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPlayer : MonoBehaviour {

    public static GlobalPlayer instance;
    public GameObject weaponHolder;

    /// <summary>
    /// Base fire rate in rounds per minute
    /// </summary>
    public float baseFireRate;

    /// <summary>
    /// Base projectile speed in units per second
    /// </summary>
    public float baseProjectileSpeed;

    public float baseProjectileDamage;

    private void Awake() {
        instance = this;
    }

    public void AddWeapon(GameObject weapon) { 
        Instantiate(weapon, weaponHolder.transform);
    }

}
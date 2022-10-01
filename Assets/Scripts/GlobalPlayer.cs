using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPlayer : MonoBehaviour {

    public static GlobalPlayer instance;
    public GameObject weaponHolder;

    public float playerMoveSpeed;

    /// <summary>
    /// Base fire rate in rounds per minute
    /// </summary>
    public float baseFireRate;

    /// <summary>
    /// Base projectile speed in units per second
    /// </summary>
    public float baseProjectileSpeed;

    public float baseProjectileDamage;

    public Health playerHealth;

    public float baseEnemyAttackCooldown;
    public float baseEnemyDamage;
    public float baseEnemyMoveSpeed;

    private void Awake() {
        instance = this;
    }

    public void AddWeapon(GameObject weapon) { 
        Instantiate(weapon, weaponHolder.transform);
    }



}

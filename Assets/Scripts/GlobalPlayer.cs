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
    public int baseProjectilePierce;

    public Health playerHealth;

    public float baseEnemyAttackCooldown;
    public float baseEnemyDamage;
    public float baseEnemyMoveSpeed;

    /// <summary>
    /// Happens once every 5 seconds
    /// </summary>
    public float healthRegen = 0f;

    public Rigidbody2D rbod;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        StartCoroutine(DoHealthRegen());
    }

    IEnumerator DoHealthRegen() {
        while (true) {
            yield return new WaitForSeconds(5f);
            playerHealth.GetHealed(healthRegen);
        }

    }

    public void AddWeapon(GameObject weapon) { 
        Instantiate(weapon, weaponHolder.transform);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAndDespawnOnImpactBehavour : MonoBehaviour {

    public float projectileDamageCoefficent = 1;

    public void OnTriggerEnter2D(Collider2D collision) {

        Health health = collision.GetComponent<Health>();

        if (health == null) return;

        health.TakeDamage(GlobalPlayer.instance.baseProjectileDamage * projectileDamageCoefficent);
        Destroy(gameObject);

    }

}

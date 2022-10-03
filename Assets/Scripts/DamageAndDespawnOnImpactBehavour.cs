using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAndDespawnOnImpactBehavour : MonoBehaviour {

    public float projectileDamageCoefficent = 1;
    public int additionalPierce = 0;

    int currentPierce = 0;

    private void Start() {
        currentPierce = additionalPierce + GlobalPlayer.instance.baseProjectilePierce;
    }

    public void OnTriggerEnter2D(Collider2D collision) {

        Health health = collision.GetComponent<Health>();

        if (health != null) health.TakeDamage(GlobalPlayer.instance.baseProjectileDamage * projectileDamageCoefficent);

        currentPierce--;       
        if (currentPierce < 0) Destroy(gameObject);

    }

}

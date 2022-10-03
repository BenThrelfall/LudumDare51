using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngulfBehavour : MonoBehaviour {

    public float damageCoefficent;

    float nextEngulfTime = 0f;

    private void OnTriggerStay2D(Collider2D collision) {
        if (Time.time > nextEngulfTime) {
            var health = collision.gameObject.GetComponent<Health>();
            if (health != null) {
                health.TakeDamage(damageCoefficent * GlobalPlayer.instance.baseProjectileDamage);
                nextEngulfTime = Time.time + 10f;
            }
        }
    }

}

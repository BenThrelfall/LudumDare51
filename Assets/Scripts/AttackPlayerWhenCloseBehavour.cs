using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayerWhenCloseBehavour : MonoBehaviour {

    Transform target;
    Health targetHealth;
    public float squaredRange;
    public float damage;
    public float attackCooldown;

    // Start is called before the first frame update
    void Start() {
        target = GlobalPlayer.instance.transform;
        targetHealth = GlobalPlayer.instance.GetComponent<Health>();
        StartCoroutine(AttackRoutine());
    }

    private IEnumerator AttackRoutine() {

        for(;;) {

            if ((transform.position - target.position).sqrMagnitude <= squaredRange) {
                targetHealth.TakeDamage(damage);
            }

            yield return new WaitForSeconds(attackCooldown);
        }

    }

}

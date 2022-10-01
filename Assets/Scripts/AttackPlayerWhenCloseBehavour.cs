using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayerWhenCloseBehavour : MonoBehaviour {

    Transform target;
    Health targetHealth;
    public float squaredRange;
    public float damageCoefficient;
    public float attackCooldownCoefficient;

    // Start is called before the first frame update
    void Start() {
        target = GlobalPlayer.instance.transform;
        targetHealth = GlobalPlayer.instance.GetComponent<Health>();
        StartCoroutine(AttackRoutine());
    }

    private IEnumerator AttackRoutine() {

        for(;;) {

            if ((transform.position - target.position).sqrMagnitude <= squaredRange) {
                targetHealth.TakeDamage(GlobalPlayer.instance.baseEnemyDamage * damageCoefficient);
            }

            yield return new WaitForSeconds(GlobalPlayer.instance.baseEnemyAttackCooldown * attackCooldownCoefficient);
        }

    }

}

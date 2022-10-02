using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhagocytosisBehavour : MonoBehaviour {

    public float fireRateCoefficient;
    public float damageCoefficient;
    public float size;
    public LayerMask layerMask;

    private void Start() {
        StartCoroutine(FiringRoutine());
    }

    IEnumerator FiringRoutine() {
        for (; ; ) {

            yield return new WaitForSeconds(60 / (fireRateCoefficient * GlobalPlayer.instance.baseFireRate));

            var cols = Physics2D.OverlapCircleAll(transform.position, size,  layerMask);

            foreach (var col in cols) {
                var health = col.GetComponent<Health>();
                if (health != null) {
                    health.TakeDamage(damageCoefficient * GlobalPlayer.instance.baseProjectileDamage);
                }
            }
            
        }
    }

}
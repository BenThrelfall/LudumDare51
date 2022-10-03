using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoturretBehavour : MonoBehaviour {

    public float fireRateCoefficient;
    public float projectileSpeedCoefficient;
    public GameObject projectile;

    public LayerMask layerMask;

    private void Start() {
        StartCoroutine(FiringRoutine());
    }

    IEnumerator FiringRoutine() {
        for (; ; ) {

            yield return new WaitForSeconds(60 / (fireRateCoefficient * GlobalPlayer.instance.baseFireRate));

            var col = Physics2D.OverlapCircle(transform.position, 6f, layerMask);

            if (col == null) continue;

            Vector2 bulletDirection = col.transform.position - transform.position;
            GameObject projectileInstance = Instantiate(projectile, transform.position + (Vector3)bulletDirection.normalized * 0.8f, Quaternion.identity);

            projectileInstance.GetComponent<Rigidbody2D>().velocity = bulletDirection.normalized * (GlobalPlayer.instance.baseProjectileSpeed * projectileSpeedCoefficient);
        }
    }

}
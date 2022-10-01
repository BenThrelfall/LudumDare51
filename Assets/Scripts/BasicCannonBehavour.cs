using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCannonBehavour : MonoBehaviour{

    public float fireRateCoefficient;
    public float projectileSpeedCoefficient;
    public GameObject projectile;

    private void Start() {
        StartCoroutine(FiringRoutine());
    }

    IEnumerator FiringRoutine() {
        for (;;) {

            yield return new WaitForSeconds(60 / (fireRateCoefficient * GlobalPlayer.instance.baseFireRate));

            Vector2 bulletDirection = Random.insideUnitCircle;
            GameObject projectileInstance = Instantiate(projectile, transform.position + (Vector3)bulletDirection.normalized * 0.8f, Quaternion.identity);

            projectileInstance.GetComponent<Rigidbody2D>().velocity = bulletDirection.normalized * (GlobalPlayer.instance.baseProjectileSpeed * projectileSpeedCoefficient);
        }
    }

}

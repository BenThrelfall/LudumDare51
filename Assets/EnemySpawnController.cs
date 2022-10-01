using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour {

    Transform playerTrans;
    public float spawnCoolDown = 5f;

    public GameObject enemyPrefab;

    private void Start() {
        playerTrans = GlobalPlayer.instance.transform;
        StartCoroutine(SpawningRoutine());
    }

    IEnumerator SpawningRoutine() {

        while (true) {
            yield return new WaitForSeconds(spawnCoolDown);
            spawnCoolDown = Mathf.Max(spawnCoolDown - 0.1f, 1f);
            Vector2 spawnPosition = Random.insideUnitCircle.normalized * 10;
            Instantiate(enemyPrefab, playerTrans.position + (Vector3)spawnPosition, Quaternion.identity);
        }

    }

}

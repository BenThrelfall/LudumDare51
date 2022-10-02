using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour {

    Transform playerTrans;
    public float spawnCoolDown = 4f;

    public GameObject RobotOne;
    public GameObject RobotTwo;
    public GameObject BioOne;


    private void Start() {
        playerTrans = GlobalPlayer.instance.transform;
        StartCoroutine(SpawningRoutine());
    }

    IEnumerator SpawningRoutine() {

        while (true) {
            spawnCoolDown = Mathf.Max(spawnCoolDown - 0.1f, 0.3f);
            Vector2 spawnPosition = Random.insideUnitCircle.normalized * 10;
            int spawn = Random.Range(0, 3);

            if (spawn == 0) {
                Instantiate(RobotOne, playerTrans.position + (Vector3)spawnPosition, Quaternion.identity);

            }
            else if (spawn == 1) { 
                Instantiate(RobotTwo, playerTrans.position + (Vector3)spawnPosition, Quaternion.identity);
            }
            else {
                Instantiate(BioOne, playerTrans.position + (Vector3)spawnPosition, Quaternion.identity);
            }

            yield return new WaitForSeconds(spawnCoolDown);
        }

    }

}

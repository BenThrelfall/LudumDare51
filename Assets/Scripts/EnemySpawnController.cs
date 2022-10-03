using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour {

    Transform playerTrans;
    public float spawnCoolDown = 4f;

    public GameObject RobotOne;
    public GameObject RobotTwo;
    public GameObject RobotThree;
    public GameObject RobotFour;
    public GameObject BioOne;
    public GameObject BioTwo;

    public AnimationCurve robotOneSpawn;
    public AnimationCurve robotTwoSpawn;
    public AnimationCurve robotThreeSpawn;
    public AnimationCurve robotFourSpawn;
    public AnimationCurve BioOneSpawn;
    public AnimationCurve BioTwoSpawn;


    private void Start() {
        playerTrans = GlobalPlayer.instance.transform;
        StartCoroutine(SpawningRoutine());
    }

    IEnumerator SpawningRoutine() {

        while (true) {


            for (int i = 0; i < Mathf.RoundToInt(5 * robotOneSpawn.Evaluate(Time.timeSinceLevelLoad / 300)); i++) {
                spawnRandom(RobotOne);
            }

            for (int i = 0; i < Mathf.RoundToInt(5 * robotThreeSpawn.Evaluate(Time.timeSinceLevelLoad / 300)); i++) {
                spawnRandom(RobotThree);
            }

            if (Random.value < robotTwoSpawn.Evaluate(Time.timeSinceLevelLoad / 300)) {
                spawnRandom(RobotTwo);
            }

            if (Random.value < robotFourSpawn.Evaluate(Time.timeSinceLevelLoad / 300)) {
                spawnRandom(RobotFour);
            }

            if (Random.value < BioOneSpawn.Evaluate(Time.timeSinceLevelLoad / 300)) {
                spawnRandom(BioOne);
            }

            if (Random.value < BioTwoSpawn.Evaluate(Time.timeSinceLevelLoad / 300)) {
                spawnRandom(BioTwo);
            }



            yield return new WaitForSeconds(spawnCoolDown);
        }

    }

    void spawnRandom(GameObject spawnObject) {

        Vector2 spawnPosition;

        if (GlobalPlayer.instance.rbod.velocity.sqrMagnitude == 0 || Random.value < 0.9f) {
            spawnPosition = Random.insideUnitCircle.normalized * 10;
        }
        else {
            spawnPosition = GlobalPlayer.instance.rbod.velocity.normalized * 10;
        }

        Instantiate(spawnObject, playerTrans.position + (Vector3)spawnPosition, Quaternion.identity);
    }

}

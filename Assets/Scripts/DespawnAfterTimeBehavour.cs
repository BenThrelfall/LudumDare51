using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnAfterTimeBehavour : MonoBehaviour {

    public float time;

    private void Start() {
        StartCoroutine(DespawnAfterTime());
    }

    IEnumerator DespawnAfterTime() {
        yield return new WaitForSeconds(time);

        Destroy(gameObject);
    }

}

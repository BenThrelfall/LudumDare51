using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDieBehavour : MonoBehaviour {

    private void OnEnable() {
        GetComponent<Health>().OnDie += DestroyOnDieBehavour_OnDie;
    }

    private void OnDisable() {
        GetComponent<Health>().OnDie -= DestroyOnDieBehavour_OnDie;
    }

    private void DestroyOnDieBehavour_OnDie() {
        Destroy(gameObject, 0.09f);
    }
}

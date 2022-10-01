using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameOnDieBehavour : MonoBehaviour {

    [SerializeField] GameObject endScreen;

    private void OnEnable() {
        GetComponent<Health>().OnDie += DestroyOnDieBehavour_OnDie;
    }

    private void OnDisable() {
        GetComponent<Health>().OnDie -= DestroyOnDieBehavour_OnDie;
    }

    private void DestroyOnDieBehavour_OnDie() {
        Time.timeScale = 0;
        endScreen.SetActive(true);
    }
}
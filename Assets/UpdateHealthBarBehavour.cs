using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHealthBarBehavour : MonoBehaviour {

    [SerializeField] Health health;
    [SerializeField] GameObject healthBar;
    [SerializeField] Animator animator;

    private void OnEnable() {
        health.OnChangeHealth += Health_OnChangeHealth;
    }

    private void OnDisable() {
        health.OnChangeHealth -= Health_OnChangeHealth;
    }

    private void Health_OnChangeHealth() {
        healthBar.transform.localScale = new Vector3((health.CurrentHealth / health.maxHealth), 0.1f, 1);
        animator.SetTrigger("Show");
    }
}

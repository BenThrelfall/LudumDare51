using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float maxHealth;
    [SerializeField] float currentHealth; 
    public float CurrentHealth { get {return currentHealth; } private set { currentHealth = Mathf.Min(value, maxHealth); OnChangeHealth?.Invoke(); } }

    public bool blessed = false;

    public event Action OnDie;
    public event Action OnChangeHealth;

    private void Start() {
        CurrentHealth = maxHealth;
    }

    public void TakeDamage(float amount) {
        CurrentHealth -= amount;
        if (CurrentHealth <= 0) Die();
    }


    public void GetHealed(float amount) {
        CurrentHealth += amount;
    }


    /// <summary>
    /// Sets health ignoring any effects
    /// </summary>
    /// <param name="amount"></param>
    public void SetHealth(float amount) {
        CurrentHealth = amount;
    }

    private void Die() {
        if (blessed) {
            blessed = false;
            currentHealth = maxHealth * 0.5f;
            return;
        }

        OnDie?.Invoke();
    }

}

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

    public bool shouldFlash = true;
    bool isFlashing = false;
    float flashTime = 0f;

    SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start() {
        CurrentHealth = maxHealth;
    }

    private void Update() {

        if (Time.time < flashTime && !isFlashing) {
            spriteRenderer.material = MaterialStorage.instance.flashMat;
            isFlashing = true;
        }
        else if (Time.time > flashTime && isFlashing) {
            spriteRenderer.material = MaterialStorage.instance.spriteDefault;
            isFlashing = false;
        }


    }

    public void TakeDamage(float amount) {
        CurrentHealth -= amount;
        flashTime = Time.time + 0.1f;
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

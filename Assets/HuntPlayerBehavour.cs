using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntPlayerBehavour : MonoBehaviour {

    Transform target;
    public float speed;

    public Rigidbody2D rbod;

    // Start is called before the first frame update
    void Start() {
        target = GlobalPlayer.instance.transform;
    }

    // Update is called once per frame
    void FixedUpdate() {

        Vector2 movementVector = (target.position - transform.position).normalized;

        rbod.velocity = movementVector * speed;

    }
}

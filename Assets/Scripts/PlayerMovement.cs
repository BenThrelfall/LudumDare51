using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] Rigidbody2D rbod;

    // Update is called once per frame
    void FixedUpdate() {

        Vector2 movementVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        rbod.velocity = movementVector.normalized * GlobalPlayer.instance.playerMoveSpeed;
    }
}

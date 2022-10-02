using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticZPosition : MonoBehaviour {

    private void Start() {
        transform.position = new Vector3(transform.position.x, transform.position.y, 20 - transform.position.y * 0.1f);
    }

}

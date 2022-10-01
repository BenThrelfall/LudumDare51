using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalPlayer : MonoBehaviour {

    public static GlobalPlayer instance;

    private void Awake() {
        instance = this;
    }

}

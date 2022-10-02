using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialStorage : MonoBehaviour {

    public static MaterialStorage instance;

    public Material spriteDefault;
    public Material flashMat;

    private void Awake() {
        instance = this;
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject prefab;

    public float width;
    public float height;
    public bool showBounds;

    public int number;

    private void OnDrawGizmos() {
        if (showBounds) {
            Gizmos.DrawCube(transform.position, new Vector3(width, height, 1));

        }
    }

    public void DoSpawning() {
        for (int i = 0; i < number; i++) {
            float x = Random.value;
            float y = Random.value;

            Instantiate(prefab, transform.position + new Vector3(width * x - width * 0.5f, height * y - height * 0.5f, 0), Quaternion.identity);

        }
    }

}

[CustomEditor(typeof(ObjectSpawner))]
public class ObjectSpawnerEditor : Editor {

    public override void OnInspectorGUI() {
        
        ObjectSpawner objectSpawner = (ObjectSpawner)target;
        
        DrawDefaultInspector();
        
        if (GUILayout.Button("Spawn")) {
            objectSpawner.DoSpawning();
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour {

    [SerializeField] TextMeshProUGUI text;

    private void Update() {
        text.text = $"Score: {Time.timeSinceLevelLoad:#}";
    }

}

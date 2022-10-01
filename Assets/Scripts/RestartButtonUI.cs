using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonUI : MonoBehaviour {

    public void OnClick() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

}

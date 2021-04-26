using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_SwitchScene : MonoBehaviour
{
    string sceneName = "GameOverScene";

    void FixedUpdate() {
        if (transform.position.y < -5.5f) {
            SceneManager.LoadScene (sceneName);
        }
    }
}

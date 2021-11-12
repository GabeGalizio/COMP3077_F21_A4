//Script to manage actions on the splash screen.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour
{
    void Update() {
        if(Input.anyKey) {
            SceneManager.LoadScene("Main Menu");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    public static int score = 0;

    void OnGui() {
        GUI.Label(new Rect(10, 10, 300, 50), "SCORE: " + score.ToString());
    }
}

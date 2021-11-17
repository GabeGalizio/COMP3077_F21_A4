using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to trigger upon entering a death zone.

public class DeathZoneTrigger : MonoBehaviour {
    private Vector3 spawnPosn;
    private Quaternion spawnRotation;

    //Get initial player posn for this scene.
    void Awake() {
        spawnPosn = GameObject.Find("Player").transform.position;
        spawnRotation = GameObject.Find("Player").transform.rotation;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name.Equals("Player")) { //Verify colliding object is player
            other.gameObject.transform.position = spawnPosn;
            other.gameObject.transform.rotation = spawnRotation;
        }
    }
}

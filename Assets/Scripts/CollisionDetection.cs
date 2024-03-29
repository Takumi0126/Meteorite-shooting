﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject explosionPrefab;
    public string targetObject;


    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.name == targetObject) {
            GameObject.Find ("Score").GetComponent<ScoreController> ().AddScore ();
            GameObject effect = Instantiate (explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy (effect, 1.0f);
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject explosionPrefab;
    public string targetObject;


    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.name == targetObject) {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
            Instantiate (explosionPrefab, transform.position, Quaternion.identity);
        }
    }
}

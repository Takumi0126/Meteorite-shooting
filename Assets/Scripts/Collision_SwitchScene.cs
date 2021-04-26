using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision_SwitchScene : MonoBehaviour
{
    public string targetObject; 
    public GameObject explosionPrefab;

    void OnCollisionEnter2D(Collision2D coll)  { 
        if (coll.gameObject.name == targetObject) {
            GameObject effect = Instantiate (explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy (effect, 1.0f);
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBullet : MonoBehaviour
{
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space)) {
            Vector2 newPos = this.transform.position;
            GameObject newGameObject = Instantiate(bulletPrefab) as GameObject;
            newGameObject.transform.position = newPos;
        }
    }
}

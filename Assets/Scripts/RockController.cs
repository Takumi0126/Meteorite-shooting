using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;

    bool showFlag = false;

    void Start () {
        this.fallSpeed = 0.01f + 0.1f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
    }
        
    void Update () {
        transform.Translate( 0, -fallSpeed, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed );

        if (GetComponent<Renderer>().isVisible) {
            // １回表示されたあと
            showFlag = true;
        } else {
            if (showFlag) {
                // 画面の外に出て消えたら、削除する
                Destroy(this.gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpeed : MonoBehaviour
{
    public float speed = 4;

    void Update()
    {
        transform.Translate (0, speed/50, 0);
    }
}

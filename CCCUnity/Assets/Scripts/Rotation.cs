using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [Range (0f,30f)]
    public float speed = 10f;
    

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}

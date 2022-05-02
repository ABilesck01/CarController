using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.Self);
    }
}

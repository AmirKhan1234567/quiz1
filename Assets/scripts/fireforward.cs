using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireforward : MonoBehaviour
{

    public float speed = 40.0f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}

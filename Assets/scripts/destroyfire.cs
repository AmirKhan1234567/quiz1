using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyfire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private float topbound = 11;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topbound)
        {
            Destroy(gameObject);
        }
    }
}

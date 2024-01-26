using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, 0, CreateObject.speed) * Time.deltaTime;

        if (transform.position.z > CreateObject.distance) Destroy(gameObject);
    }
}

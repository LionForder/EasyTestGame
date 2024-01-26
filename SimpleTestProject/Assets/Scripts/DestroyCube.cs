using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    internal static List<GameObject> list;
    private void Start()
    {
        list = new List<GameObject>();
    }
    void Update()
    {
        foreach (var i in list)
        {
            if (i.transform.position.z > CreateObject.distance)
            {
                Destroy(i);
            }
        }
    }
}

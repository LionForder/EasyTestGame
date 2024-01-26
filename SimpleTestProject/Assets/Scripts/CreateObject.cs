using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    [SerializeField] Transform startPoint;
    [SerializeField] TMP_InputField speedTMP, distanceTMP, timeTMP;
    internal static float speed, distance, timer;
    private void Start()
    {
        StartCoroutine(WaitSec());
    }

    void Update()
    {
        speed = float.TryParse(speedTMP.text, out var value1) ? value1 : 1;
        distance = float.TryParse(distanceTMP.text, out var value2) ? value2 : 1;
        timer = float.TryParse(timeTMP.text,out var value3) ? value3 : 1;
    }


    IEnumerator WaitSec()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = transform.position;
        cube.AddComponent<CubeMovement>();
        yield return new WaitForSeconds(timer);
        StartCoroutine(WaitSec());
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform obj;

    void Start()
    {

    }


    void LateUpdate()
    {
        transform.position = new Vector3(obj.position.x, obj.position.y + 0.1f, transform.position.z);
    }
}
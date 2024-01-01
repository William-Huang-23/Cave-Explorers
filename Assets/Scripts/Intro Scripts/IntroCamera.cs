using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCamera : MonoBehaviour
{
    [SerializeField]
    private Transform obj;

    void Start()
    {

    }


    void LateUpdate()
    {
        transform.position = new Vector3(obj.position.x, transform.position.y, transform.position.z);
    }
}

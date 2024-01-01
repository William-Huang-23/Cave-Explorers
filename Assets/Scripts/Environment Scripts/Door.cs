using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private Transform exit;

    [SerializeField]
    private Transform subject;

    void Start()
    {
        
    }


    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            subject.position = new Vector3(exit.position.x, exit.position.y, exit.position.z);
        }
    }
}

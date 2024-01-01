using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject eagle;

    [SerializeField]
    private int interval;

    private int timer;

    void Start()
    {
        
    }

 
    void Update()
    {
        timer++;
        if (timer >= interval)
        {
            spawn();
            timer = 0;
        }
    }

    void spawn()
    {
        Instantiate(eagle);
    }
}

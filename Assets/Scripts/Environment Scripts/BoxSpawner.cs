using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] box;

    [SerializeField]
    private int interval;

    private int timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        timer++;
        if(timer >= interval)
        {
            spawn();
            timer = 0;
        }
    }

    void spawn()
    {
        if(box.Length % 2 == 0)
        {
            int size1 = Random.Range(0, (box.Length / 2));
            int size2 = Random.Range(box.Length / 2, box.Length);
            print("Size1: " + size1);
            print("Size2: " + size2);
            Instantiate(box[size1]);
            Instantiate(box[size2]);
        }

        if (box.Length % 2 != 0)
        {
            int size1 = Random.Range(0, box.Length / 2);
            int size2 = Random.Range((box.Length / 2) + 1, box.Length);
            Instantiate(box[size1]);
            Instantiate(box[size2]);
        }
    }
}

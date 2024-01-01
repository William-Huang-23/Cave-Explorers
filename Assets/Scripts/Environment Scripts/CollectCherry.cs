using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCherry : MonoBehaviour
{
    private GameManager gm;

    private bool get = false;

    void Start()
    {
        gm = GameManager.instance;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if(!get)
            {
                gm.addCherry();
                get = true;
            }
            

            Destroy(this.gameObject);
        }
    }
}

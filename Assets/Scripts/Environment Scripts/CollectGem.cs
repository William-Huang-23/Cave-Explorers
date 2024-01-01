using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{
    private GameManager gm;
    private bool get = false;

    void Start()
    {
        gm = GameManager.instance;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            if(!get)
            {
                gm.addScore(200);
                get = true;
            }
            Destroy(this.gameObject);
        }
    }
}

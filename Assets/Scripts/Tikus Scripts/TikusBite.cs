using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TikusBite : MonoBehaviour
{
    private GameManager gm;
    void Start()
    {
        gm = GameManager.instance;
    }

    void Update()
    {
        
    }

   private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gm.addScore(-100);
            Destroy(col.gameObject);
            SceneManager.LoadScene(3);
        }
    }
}

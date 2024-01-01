using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxDestroy : MonoBehaviour
{
    BoxSpawner create = new BoxSpawner();
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(3);
            //Time.timeScale = 0f;
        }
    }
}

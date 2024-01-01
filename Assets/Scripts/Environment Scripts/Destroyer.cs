using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(3);
            //Time.timeScale = 0f;
        }

        if (col.gameObject.tag == "Box")
        {
            Destroy(col.gameObject);
        }
    }
}

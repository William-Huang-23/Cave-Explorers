using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EagleMove : MonoBehaviour
{
    Rigidbody2D body;
    [SerializeField]
    private float speed;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        //transform.position = new Vector3(start.transform.position.x, start.position.y, transform.position.z);
    }
    
    void Update()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene(3);
        }
    }
}

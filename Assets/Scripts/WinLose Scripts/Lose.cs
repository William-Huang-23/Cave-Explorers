using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    private AudioSource source;
    bool trigger;
    void Start()
    {
        source = GetComponent<AudioSource>();
        trigger = false;
    }

    void Update()
    {
        if(!trigger)
        {
            source.Play();
            trigger = true;
        }
        
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("MainMenu");    
        }
    }
}

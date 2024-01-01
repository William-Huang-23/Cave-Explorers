using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource bgm;
    public float soundRate = 0.5f;

    void Start()
    {
        bgm = GetComponent<AudioSource>();
        bgm.loop = true;
        if(!bgm.isPlaying)
        {
            bgm.Play();
        }
    }

    void Update()
    {
        if(PauseMenu.paused)
        {
            bgm.Pause();
            if(PauseMenu.checkSong == true)
            {
                bgm.UnPause();
            }
        }

        else
        {
            bgm.UnPause();
            PauseMenu.checkSong = false;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            bgm.mute = !bgm.mute;
        }

        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            if (bgm.volume < 1)
                bgm.volume += soundRate;
        }

        if (Input.GetKeyDown(KeyCode.Minus) || Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            if (bgm.volume > 0)
                bgm.volume -= soundRate;
        }
    }
}

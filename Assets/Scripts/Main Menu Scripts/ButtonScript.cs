using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public static bool checkButton = false;
    [SerializeField]
    private Button resume;
    void Update()
    {
        if(checkButton == true)
        {
            EnableResume();
        }

        else
        {
            DisableResume();
        }
    }

    public void EnableResume()
    {
        resume.interactable = true;
    } 

    public void DisableResume()
    {
        resume.interactable = false;
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(5);
    }
    
    public void exit()
    {
        Application.Quit();
    }

    public void back()
    {
        SceneManager.LoadScene(1);
    }
}

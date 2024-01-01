using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    public GameObject cherry1, cherry2, cherry3;
    public Vector2 lastCheckpointPos;

    private static int score = 0;
    private static int cherry = 0;

    int time;

    public static GameManager instance;

    void Start()
    {
        cherry1.gameObject.SetActive(false);
        cherry2.gameObject.SetActive(false);
        cherry3.gameObject.SetActive(false);
    }

    void Update()
    {
        scoreText.text = "Score: " + score;

        switch (cherry)
        {
            case 1:
                cherry1.gameObject.SetActive(true);
                cherry2.gameObject.SetActive(false);
                cherry3.gameObject.SetActive(false);
                break;

            case 2:
                cherry1.gameObject.SetActive(true);
                cherry2.gameObject.SetActive(true);
                cherry3.gameObject.SetActive(false);
                break;

            case 3:
                cherry1.gameObject.SetActive(true);
                cherry2.gameObject.SetActive(true);
                cherry3.gameObject.SetActive(true);
                break;
        }
    }

    void Awake()
    {
        instance = this;

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void addScore(int value)
    {
        score += value;
    }

    public void addCherry()
    {
        cherry++;

        
        
    }

    public void reset()
    {
        cherry = 0;
        score = 0;
    }
}

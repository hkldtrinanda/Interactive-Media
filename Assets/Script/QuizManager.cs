using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject End;
    public Text Scoring;
    private int score;
    public string scene;

    int currentLevel;
    void Start () {
   
        Scoring.text = "";
 
    }

    private void Update()
    {
        Scoring.text = "" + score;
    }

    public void wrongAnswer()
    {
        // ResetScreen.SetActive(true);
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
            score = score + 0;
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
            score = score + 0;
        }
    }

    public void NextScene ()
    {
        SceneManager.LoadScene(scene);
    }

    
    public void correctAnswer()
    {
        if(currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
            score = score + 33;
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
            score = score + 33;
        }
    }




}

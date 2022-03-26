using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class EndedVideo : MonoBehaviour
{
    public VideoPlayer VideoPlayer;
    public string scene;// Drag & Drop the GameObject holding the VideoPlayer component
    void Start()
    {
        VideoPlayer.loopPointReached += LoadScene;
    }
    void LoadScene(VideoPlayer vp)
    {
        SceneManager.LoadScene(scene);
    }
    
}
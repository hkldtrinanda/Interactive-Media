using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string scene;

    public void NextScene ()
    {
        SceneManager.LoadScene(scene);
    }

    // Update is called once per frame

    public void QuitApp()
    {
        Application.Quit();
    }
}

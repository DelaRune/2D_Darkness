using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SturtGame : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void ClickExit()

    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyButtontoChageLevel : MonoBehaviour
{

    public void ChangetoMain()
    {
        SceneManager.LoadScene("MainLevel");
    }
    public void ChangetoLvOne()
    {
        SceneManager.LoadScene("LevelOne");
    }
    public void ChangetoLvTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }
    public void ChangetoLeThree()
    {
        SceneManager.LoadScene("LevelThree");
    }
}
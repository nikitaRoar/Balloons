using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public static  bool isClicked;

    public void TaskOnClick()
    {
        isClicked = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
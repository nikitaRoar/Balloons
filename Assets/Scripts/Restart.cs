using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    bool isClicked;

    public void TaskOnClick()
    {
        isClicked = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Update()
    {
        if (isClicked == true)
        {
            Move.speed = 1;
        }
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour
{
    private float balloonsFall;
    [SerializeField] private Text balloonsText;
    public GameObject buttonRestart;
    public static bool finished = false;

    private void OnTriggerEnter(Collider other)
   
    {
        if (other.gameObject.tag == "Balloons")
        {
            balloonsFall++;
            balloonsText.text = balloonsFall.ToString();
            Destroy( other.gameObject);
            if (balloonsFall == 10)
            {
                finished = true;
                buttonRestart.SetActive(true);
            }
        }
    }

}

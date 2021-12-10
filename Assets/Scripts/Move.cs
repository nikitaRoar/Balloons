using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector2 direction;
    public static float  speed;



    void Start()
    {
        StartCoroutine(Accelerate());

    }
    void Update()
    {
        transform.Translate(speed * direction * Time.deltaTime);
    }
    
    IEnumerator Accelerate()
    {
        speed = speed + 0.2f;
        yield return new WaitForSeconds(5f);
    }
}

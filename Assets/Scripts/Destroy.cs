using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    private float balloonsCount;
    [SerializeField] private Text balloonsText;
    [SerializeField] private GameObject explosion;
    

    public void Update()
    {
       if (Restart.isClicked == true)
        {
            Fall.finished = false;
            Move.speed = 1;

            Restart.isClicked = false;
        }
        if (Fall.finished == true)
        {

            return;
        }
      
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
              var clone =  Instantiate(explosion, hit.transform.position, Quaternion.identity);
                Destroy(hit.transform.gameObject);
                Destroy(clone.gameObject,0.3f);
                
                balloonsCount++;
                balloonsText.text = balloonsCount.ToString();
               
            }
            
        }
      
    }
    
    
    
}

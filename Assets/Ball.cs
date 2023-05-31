using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    private int startY;
    // Start is called before the first frame update
    void Start()
    {
       startY = (int)transform.position.y; 
    }

    // Update is called once per frame
    void Update()
    {
        if (startY - transform.position.y > 100){
            Destroy(gameObject);
        }
    }
}

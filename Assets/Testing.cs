using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            GameObject cloneSphere = Instantiate(sphere, new Vector3(50, 111, 86), Quaternion.identity);
            cloneSphere.GetComponent<Rigidbody>().velocity +=  new Vector3(0, 0 , -1f);
        }
        if (Input.GetMouseButtonDown(1)){
            GameObject cloneSphere = Instantiate(sphere, new Vector3(50, 111, 86), Quaternion.identity);
            cloneSphere.GetComponent<Rigidbody>().velocity +=  new Vector3(0, 0 , 1f);
        }
    }
}

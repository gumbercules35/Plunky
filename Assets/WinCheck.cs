using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{   
    private bool isWinner = true;
    
    private void Start() {
        int oddOrEven = (int)Random.Range(0, 100) % 2;
        if(oddOrEven == 0){
            isWinner = false;
            Color failGate = new Color(255, 0, 0 , 0.25f);
            GetComponent<MeshRenderer>().material.color = failGate;
        }
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Triggered");
        if (other.gameObject.tag == "Ball"){
            Debug.Log("Winner? : " + isWinner);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        
        GameManager.instance.UpdateScore(1);
       
        Destroy(gameObject);
    }
}

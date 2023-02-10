using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scor : MonoBehaviour
{
    public float rotationSpeed;
    
    private void Update()
    {
        //objenin kendi etrafýnda donmesi , zyonu
       transform.Rotate(new Vector3(0, Time.deltaTime * rotationSpeed, 0));
    }
    
}

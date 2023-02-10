using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class START : MonoBehaviour
{
    private void Update()
    {
        
        if (Input.GetMouseButtonUp(0))
        {

            GameManager.instance.isGameStart = true;
            
            gameObject.SetActive(false);
        }
    }
}

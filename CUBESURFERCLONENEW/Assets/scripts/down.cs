using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class down : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "dead")
        {
            transform.DOScale(new Vector3(1.3f, 1.3f, 1.3f), 0.1f).OnComplete(() =>
            {
                // 0.1f saniyede x y z boyle plur
                transform.DOScale(new Vector3(1f, 1f, 1f), 0.1f);
                //0.2f saniyede  y  boyle plur
                transform.DOLocalMoveY(-3f, 0.2f);
            });
        }
            
                
            
        
    }
}

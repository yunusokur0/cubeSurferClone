using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fnish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cube"))
        {
            
            other.transform.parent = null;
           
            Player.instance.cubes.Remove(other.gameObject);
           
            Destroy(other.gameObject, 2f);

            
            if (Player.instance.cubes.Count == 0)
            {
                
                GameManager.instance.isGameWin = true;
                
                GameManager.instance.WinPanel();
            }
        }
    }
}

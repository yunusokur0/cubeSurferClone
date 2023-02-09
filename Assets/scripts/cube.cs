using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    private Transform player;
   

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("cubet"))
        {
            other.transform.parent = player;

            
            Vector3 lastParent = Player.instance.cubes[Player.instance.cubes.Count - 1].transform.localPosition;

           
            other.transform.localPosition = lastParent - new Vector3(0, transform.localScale.x, 0);

            
            player.position += Vector3.up;

           
            Player.instance.cubes.Add(other.gameObject);

            
            other.tag = "cube";

           

        }
        else if (other.gameObject.CompareTag("Finish"))
        {
            GameManager.instance.isFinish = true;
        }
    }

}

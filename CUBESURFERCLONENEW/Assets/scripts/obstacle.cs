using DG.Tweening.Core.Easing;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class obstacle : MonoBehaviour
{
    private Transform player;
    [SerializeField] private float waitOnAir;
    
    [SerializeField] private float fallSpeed;
    private static bool isHit = false;
    public GameObject slinder;
    [SerializeField] private float _spinSpeed;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    

   
    private void OnTriggerEnter(Collider other)
    {
        if (!isHit) 
        {
            StartCoroutine(HitUpdate());

            
            int indexNum = other.transform.GetSiblingIndex() - 2; 
             
            int listCount = Player.instance.cubes.Count;

            for (int i = indexNum; i < listCount; i++)
            {
                
                Player.instance.cubes[indexNum].transform.parent = null;
                
                Player.instance.cubes.RemoveAt(indexNum);

            }

            if (Player.instance.cubes.Count == 0)
            {
                GameManager.instance.isGameOver = true;
               
                GameManager.instance.FailPanel();
            }
            else
            {
                StartCoroutine(Gravity(listCount - indexNum));
            }
        }
    }

    private IEnumerator Gravity(int height)
    {
       
        yield return new WaitForSeconds(waitOnAir);

        
        player.DOMoveY(Player.instance.cubes.Count, fallSpeed * height);

       
    }

    private IEnumerator HitUpdate() 
    {
        isHit = true;
        yield return new WaitForSeconds(1.5f);
        isHit = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public float forwartspeed;
    public Camera cam;
    private Vector3 firstTouchPos;
    private Vector3 leftTouchPos;
    private float endPosx;
    public float borderx;
    private float sensibility = 0.01f;
    public List<GameObject> cubes = new List<GameObject>();
    private TrailRenderer tr;
    public LayerMask groundLayer;


    void Start()
    {
        instance = this;
        tr = GameObject.FindGameObjectWithTag("Trail").GetComponent<TrailRenderer>();
    }

   
    void Update()
    {

        if (GameManager.instance.isGameOver || GameManager.instance.isGameWin || !GameManager.instance.isGameStart)
        {
            return;
        }

        Trail();

        transform.position += new Vector3(0, 0, forwartspeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {

            firstTouchPos = Input.mousePosition;
        }


        if (Input.GetMouseButton(0))
        {

            leftTouchPos = Input.mousePosition;

            Vector2 touchDelta = (leftTouchPos - firstTouchPos);

            endPosx = (transform.position.x + (touchDelta.x * sensibility));

            endPosx = Mathf.Clamp(endPosx, -borderx, borderx);

            transform.position = new Vector3(endPosx, transform.position.y, transform.position.z);

            firstTouchPos = Input.mousePosition;
        }
        
    }

    private void Trail()
    {
        
        tr.transform.position = cubes[cubes.Count - 1].transform.position - new Vector3(0, 0.48f, 0);

       
        if (Physics.Raycast(cubes[cubes.Count - 1].transform.position, Vector3.down, 0.51f, groundLayer))
        {
            
            tr.emitting = true;
        }
        else
        {
            tr.emitting = false;
        }
    }

}

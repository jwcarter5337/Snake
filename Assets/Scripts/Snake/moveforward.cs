using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class moveforward : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float movementSpeed;
    public Rigidbody2D SnakeHead;


    void Start()
    {
        SnakeHead = GetComponent<Rigidbody2D>();
        InvokeRepeating("MoveSnakeHeadForward", 1.0f, 1.0f);
    }

    void MoveSnakeHeadForward()
    {
        SnakeHead.velocity = new Vector2(0, 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            
            Debug.Log("dicks");
        }
    }
    void FixedUpdate()
    {
        
    }
}

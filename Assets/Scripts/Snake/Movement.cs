using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //[InspectorName("RightButton")] public KeyCode Right;
    //[InspectorName("LeftButton")] public KeyCode Left;

    //public GameObject SnakeHead;
    //public Rigidbody2D SnakeHeadOb;
    public float speed;
    public float rotationSpeed;

    //private float revSpeed = 50.0f;


    // Start is called before the first frame update

    void Start()
    {
        //SnakeHeadOb = GetComponent<Rigidbody2D>();
        //SnakeHeadOb.velocity = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        //transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

        if (movementDirection !=Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        
        var forward = transform.forward;
        transform.position += new Vector3(movementDirection.x,movementDirection.y,0) * speed * inputMagnitude * Time.deltaTime;

    }

    //void FixedUpdate()
    //{

    //    //Quaternion targetRotation = Quaternion.LookRotation(SnakeTurn);

    //    if (Input.GetKey(Right))
    //    {
    //        SnakeHead.MoveRotation(SnakeHead.rotation - 90 * Time.fixedDeltaTime);
    //        //targetRotation = Quaternion.RotateTowards(
    //        //    transform.rotation,
    //        //    targetRotation,
    //        //    360 * Time.fixedDeltaTime);
    //    }
    //    if (Input.GetKey(Left))
    //    {
    //        SnakeHead.MoveRotation(SnakeHead.rotation + 90 * Time.fixedDeltaTime);
    //        //targetRotation = Quaternion.RotateTowards(
    //        //    transform.rotation,
    //        //    targetRotation,
    //        //    -360 * Time.fixedDeltaTime);
    //    }
    }

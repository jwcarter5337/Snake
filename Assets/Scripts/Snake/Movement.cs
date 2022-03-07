using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [InspectorName("UpButton")] public KeyCode Up;
    [InspectorName("RightButton")] public KeyCode Right;
    [InspectorName("LeftButton")] public KeyCode Left;

    public GameObject SnakeHeadOb;
    private Rigidbody2D SnakeHead;
    private Rigidbody2D SnakeBody;
    public int SnakeSpeed;
    private float revSpeed = 50.0f;


    // Start is called before the first frame update
    void Start()
    {
        SnakeHead = GetComponent<Rigidbody2D>();
        SnakeBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Up))
        {
            SnakeHead.velocity = new Vector2(2, 0);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(Right))
        {
            SnakeHead.MoveRotation(SnakeHead.rotation + revSpeed *Time.fixedDeltaTime);
        }
    }
}

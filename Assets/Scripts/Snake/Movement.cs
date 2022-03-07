using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [InspectorName("RightButton")] public KeyCode Right;
    [InspectorName("LeftButton")] public KeyCode Left;

    public GameObject SnakeHeadOb;
    private Rigidbody2D SnakeHead;
    public Vector3 SnakeTurn;

    //private float revSpeed = 50.0f;


    // Start is called before the first frame update
    void Start()
    {
        SnakeHead = GetComponent<Rigidbody2D>();
        SnakeHead.velocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void FixedUpdate()
    {

        Quaternion targetRotation = Quaternion.LookRotation(SnakeTurn);

        if (Input.GetKey(Right))
        {
            targetRotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                360 * Time.fixedDeltaTime);
        }
        if (Input.GetKey(Left))
        {
            targetRotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                -360 * Time.fixedDeltaTime);
        }
    }
}

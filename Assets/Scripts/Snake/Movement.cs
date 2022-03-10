using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    private Vector2 _lastAnalogForward;

    public GameObject Body;
    void Start()
    {

    }

    

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();
      
        if (movementDirection != Vector2.zero)
        {
          
            {
                _lastAnalogForward = movementDirection;
            }

            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        var moveDirection = new Vector3(_lastAnalogForward.x, _lastAnalogForward.y, 0);
        transform.position += moveDirection * speed * Time.deltaTime;
    }

    //void OnTriggerEnter2D(Collider2D coll)
    //{
    //    if (coll.tag == "snakeHead")
    //        Destroy(coll.gameObject);
    //}
}
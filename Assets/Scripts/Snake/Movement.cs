using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using System.Linq;

public class Movement : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    private Vector2 _lastAnalogForward;
    public GameObject Body;
    public Rigidbody2D snakeHead;
    private Vector3 lastSpawnPoint;
    private GameObject endTail;

    private List<Vector3> coords = new List<Vector3>();
    

    void Start()
    {
        endTail = gameObject;
    }

    void Update()
    {
        //Rotating movement
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
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        var moveDirection = new Vector3(_lastAnalogForward.x, _lastAnalogForward.y, 0);
        transform.position += moveDirection * speed * Time.deltaTime;

        //Play sound when right is pressed
        //if (movementDirection == Vector2.up)
        //{
        //    FindObjectOfType<AudioManager>().Play("SnakeSound");
        //}

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.gameObject.tag == "food")

        {
            var spawnPos = endTail.transform.position + endTail.transform.up * -1;

            //spawn a tail piece;
            var tempEndTail = endTail;
            endTail = Instantiate(Body, spawnPos, Quaternion.identity);
            var tail = endTail.GetComponent<Tail>();
            tail.obToFollow = tempEndTail;

            //Play food sound
            FindObjectOfType<AudioManager>().Play("FoodPickup");
        }

        if (other.gameObject.tag == "Border" || other.gameObject.tag == "SnakeBody")
        {
            speed = 0;
        }

        

    }
  
 
    

    
    



    //tell the tail piece which object to follow;


        //for (int i = 0; i < coords.Count; i++)
        //{
        //    var item = coords[i];
        //}
        //if (other.gameObject.tag == "food");
        //{
        //    coords.Add(gameObject.transform.position);
        //    foreach (var item in coords)
        //    {
        //        Debug.Log(item);
        //    }
        //    coords.Remove(gameObject.transform.position);
        //    Debug.Log("help");



        //var spawnPos = Vector3.MoveTowards(lastSpawnPoint, transform.position, 10);
        //Instantiate(Body, spawnPos, Quaternion.identity);
        //lastSpawnPoint = spawnPos;
    
   
        
}


    //add coords to queue following the snake head spawning body along way

    //void Move()
    //{
    //    // Save current position (gap will be here)
    //    Vector2 v = transform.position;

    //    // Move head into new direction (now there is a gap)
    //    transform.Translate(dir);

    //    // Do we have a Tail?
    //    if (snakeBody.Count > 0)
    //    {
    //        // Move last Tail Element to where the Head was
    //        snakeBody.Last().position = v;

    //        // Add to front of list, remove from the back
    //        snakeBody.Insert(0, snakeBody.Last());
    //        snakeBody.RemoveAt(snakeBody.Count - 1);
    //    }
    //}
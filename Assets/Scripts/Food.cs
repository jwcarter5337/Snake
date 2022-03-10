using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject foodPrefab;
    public Transform borderTop;
    public Transform BorderLeft;
    public Transform borderRight;
    public Transform borderBottom;
    public GameObject snakeHead;
    private bool ate;

    void Start()
    {
        ate = false;
        int x = (int)Random.Range(BorderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderTop.position.y, borderBottom.position.y);

        Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
    }

    void Spawn()
    {
        int x = (int) Random.Range(BorderLeft.position.x,borderRight.position.x);
        int y = (int)Random.Range(borderTop.position.y, borderBottom.position.y);

        Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
    }

    //void Update()
    //{
        void OnTriggerEnter2D(Collider2D coll)
        {
            //if (coll.gameObject.tag == "food")
            {
                // Get longer in next Move call
                ate = true;
                
                Debug.Log("dicks");

                // Remove the Food
                Destroy (coll.gameObject);

            }
            // Collided with Tail or Border
        }
    }
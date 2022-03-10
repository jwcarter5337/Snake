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
    //public BoxCollider2D foodbc;
    private bool ate;

    void Start()
    {
        ate = false;
        int x = (int) Random.Range(BorderLeft.position.x, borderRight.position.x);
        int y = (int) Random.Range(borderTop.position.y, borderBottom.position.y);

        Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
        //Instantiate(foodbc, new Vector2(x, y), Quaternion.identity);
    }

    //void Spawn()
    //{
    //    int x = (int) Random.Range(BorderLeft.position.x, borderRight.position.x);
    //    int y = (int) Random.Range(borderTop.position.y, borderBottom.position.y);

    //    Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggers detected");
        if (other.gameObject.tag == "food")
        {
            // get longer in next move call
            ate = true;

            Debug.Log("dicks");

            // Remove the Food

            Destroy(other.gameObject);
        }
    }
}
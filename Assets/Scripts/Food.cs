using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Food : MonoBehaviour
{
    public GameObject foodPrefab;
    public Transform borderTop;
    public Transform BorderLeft;
    public Transform borderRight;
    public Transform borderBottom;
    //public BoxCollider2D foodbc;
    //private bool ate;

    Vector3 lastUpdate;



    void Start()
    {
        //ate = false;
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
        if (other.gameObject.tag == "food")
        {
            //ate = true;
            Destroy(other.gameObject);

            //spawn new food
            int x = (int)Random.Range(BorderLeft.position.x, borderRight.position.x);
            int y = (int)Random.Range(borderTop.position.y, borderBottom.position.y);

            Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
            
        }
        //if (other.gameObject.tag == "Border" || other.gameObject.tag == "SnakeBody")
        //{
        //    Debug.Log("Game Over");
        //}
        //if (other.gameObject.tag == "Border")
        //to do: game over screen
    }
}
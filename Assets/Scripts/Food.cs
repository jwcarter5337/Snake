using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject SnakeHead;
    public Rigidbody2D Foodrb;

    // Start is called before the first frame update
    void Start()
    {
        Foodrb = GetComponent<Rigidbody2D>();
    }

    private void DestroyGameObject(Collision2D FoodGameObject)
    {
        if(FoodGameObject.gameObject.name == "SnakeHead")
        Destroy(FoodGameObject.gameObject);
        Debug.Log("Dicks");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

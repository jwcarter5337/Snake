using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverUI;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Border" || other.gameObject.tag == "SnakeBody")
        {
            gameOverUI.SetActive(true);
            FindObjectOfType<AudioManager>().Play("GameOverSound");
        }
    }
}

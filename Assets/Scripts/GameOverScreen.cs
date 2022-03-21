using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameOverScreen : MonoBehaviour
{




    
    public void Quit()
    {
        Debug.Log("Application Quit");
        Application.Quit();
    }

    public void Retry ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //public void EndGame()
    //{
    //    void OnTriggerEnter2D(Collision Collision)
    //    {
    //        if (Collision.gameObject.tag == "Border" || Collision.gameObject.tag == "SnakeBody")
    //        {
    //            Debug.Log("Game Over");
    //        }
    //    }
    //}
}

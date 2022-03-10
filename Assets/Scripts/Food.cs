using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    void DestroyScriptInstance()
    {
        // Removes this script instance from the game object
        Destroy(this);
    }

    void DestroyComponent()
    {
        // Removes the rigidbody from the game object
        Destroy(GetComponent<Rigidbody>());
    }
    // When the user presses Ctrl, it will remove the
    // BoxCollider component from the game object
    void OnCollisionEnter2D()
    {
        if ( && GetComponent<BoxCollider>())
        {
            Destroy(GetComponent<BoxCollider>());
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public GameObject obToFollow;
    public float close;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var Distance = obToFollow.transform.position - transform.position;
        if (Distance.magnitude >= close)
        {
            //move tail towards snake head;
            transform.position += Distance * Time.deltaTime * 5;
        }
    }
}

/*
* Kayden Miller
* Assignment 3
* Moving the player character using the keyboard inputs
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horiInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {

        horiInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horiInput * Time.deltaTime * speed);

        if(transform.position.x <-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x >xRange)
        {
            transform.position =  new Vector3(xRange,transform.position.y, transform.position.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    //Public variables
    public float speed = 10.0f;
    public float turnSpeed = 0.0f;
    public float horizontalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // input system from here
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed) ;
       // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
       // we turn the vehicle from here
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * turnSpeed * horizontalInput);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMovement : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       float throttle =  Input.GetAxis("Vertical"); //"throttle" moves the tank along the vertical axis
       transform.Translate(0.0f, 0.0f, throttle * Time.deltaTime * speed); //move along the vertical axis with the "speed" variable
       //don't move x or y, move z with throttle variable + time + speed variable

       float steering = Input.GetAxis("Horizontal"); //"steering" rotates the tank along the horizontal access
       float turn = steering * turnSpeed * Time.deltaTime; //rotate and move with the "turnSpeed" variable
       transform.Rotate (0.0f, turn, 0.0f); //don't move x, apply turn variable to y, don't move z
       
       /*
       float movement =  throttle * speed * Time.deltaTime;
       if (Input.GetKey(KeyCode.W)) {
            Transform t = gameObject.transform;
            t.Translate (0.0f, 0.0f, movement);
       }
       if (Input.GetKey(KeyCode.S)) {
            Transform t = gameObject.transform;
            t.Translate (0.0f, 0.0f, movement*-1);
       }*/
    }
}

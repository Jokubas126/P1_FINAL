using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody player; //for adding force
    public Transform playermove; //for constant movement and rotation

    public float push; // the size of the push when extending fingers
    public float velocity; // current velocity
    public float maxvelocity;
    //public float minvelocity;

    public float stop; //speed of stopping 
    public float constantspeed; // speed of the plane, when nothing is being done

    public float angle;
    
	// Update is called once per frame
	void Update () {


        if (velocity > constantspeed)
        {
            velocity -= stop * Time.deltaTime;
            playermove.Translate(Vector3.forward * velocity); // moves player forward   
            playermove.Rotate(Vector3.up * velocity * angle * Time.deltaTime); //turns player by the angle which gets as big as velocity is
        }
        else
        {
            velocity = 0;
            playermove.Translate(Vector3.forward * velocity);
        }
    }

    public void PrintActivateMesssage()
    {
        if (velocity < maxvelocity)
        {
            velocity += push * Time.deltaTime;
            player.AddForce(Vector3.forward * velocity/*, ForceMode.VelocityChange*/);
        }
    }
}
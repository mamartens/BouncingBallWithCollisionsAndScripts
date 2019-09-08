using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOffFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

   
    // OnTriggerEnter is called whenever a collision is detected between 
    // this object (which is the BouncingBall in this example) and another ojbect.
       void OnTriggerEnter(Collider other)
    {

        Vector3 v3Position;
        v3Position = this.transform.position;
        
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 v3Velocity = rb.velocity;
       
        print("Detected collision between " + this.name + " and " + other.name + "\n" +
           "Position" + v3Position.ToString("F4") + " and " + "Velocity" + v3Velocity.ToString("F4") );

        // Reverse the vertical (y-axis) velocity to simulate an elastic collisions
        float Vx = v3Velocity.x;
        float Vy = v3Velocity.y;
        float Vz = v3Velocity.z;
        v3Velocity = new Vector3(Vx, -Vy, Vz);
        rb.velocity = v3Velocity;

        
    }
}
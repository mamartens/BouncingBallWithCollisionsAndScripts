using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceOffFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Called BounceOffFloor.Start()");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 v3Velocity = rb.velocity;
        float Vx = v3Velocity.x;
        float Vy = v3Velocity.y;
        float Vz = v3Velocity.z;

        print("Detected collision between " + this.name + " and " + other.name);
        print("Velocity" + v3Velocity);
        v3Velocity = new Vector3(Vx, -Vy, Vz);
        rb.velocity = v3Velocity;
    }
}
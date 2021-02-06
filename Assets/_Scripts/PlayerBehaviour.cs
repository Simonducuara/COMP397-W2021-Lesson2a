using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            // move to the right

            //two ways to typen the movement to the right times movementforce
            //rigidbody.AddForces(new Vector3(1.0f, 0.0f, 0.0f) * movementForce);
            rigidbody.AddForce(Vector3.right * movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            // move to the left
            rigidbody.AddForce(Vector3.left * movementForce);
        }

    }
}

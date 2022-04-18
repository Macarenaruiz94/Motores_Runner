using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int JumpForce;
    public int speed = 7;
    public Rigidbody rb;
    
    void Start()
    {
        
    }


    void Update()
    {
        /*if (Input.GetKeyDown("space"))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));
        }

        this.GetComponent<Rigidbody>().velocity = new Vector3(0, speed, this.GetComponent<Rigidbody>().velocity.y);
    }*/
    }

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }
}

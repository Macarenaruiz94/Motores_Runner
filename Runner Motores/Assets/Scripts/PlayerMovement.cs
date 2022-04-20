using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown("space"))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));
        }
    }

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Obstaculo")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

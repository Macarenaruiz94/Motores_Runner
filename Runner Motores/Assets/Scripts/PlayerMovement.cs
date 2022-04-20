using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public int JumpForce;
    public int speed = 7;
    public Rigidbody rb;
    public Text timerText;
    float startTime;
    bool meta = false;
    
    
    void Start()
    {
        startTime = Time.time;
    }


    void Update()
    {
        if (meta)
            return;

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
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

    public void Meta()
    {
        meta = true;
        timerText.color = Color.green;
    }
}

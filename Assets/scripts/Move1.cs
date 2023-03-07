using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public float moveSpeed = 10;
    public int jumpForce=1;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            //Debug.Log("right");
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            //Debug.Log("left");
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
            Debug.Log("down");
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("up");
            //transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            //rb.AddForce(Vector2.up * jumpForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 30;
        }

    }

 
 
}
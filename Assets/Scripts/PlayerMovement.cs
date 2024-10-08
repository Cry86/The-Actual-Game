using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float jump;
    public bool isJumping;
    public CoinManager cm;
    private Rigidbody2D rb;
    public int jumpMultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump * jumpMultiplier));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isJumping = true;
    }

    public static implicit operator PlayerMovement(bool v)
    {
        throw new NotImplementedException();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            cm.coinCount++;
        }
        if (other.gameObject.CompareTag("Boost"))
        {
            jumpMultiplier += 1;
            if (jumpMultiplier > 2)
            {
                jumpMultiplier = 2;
            }
        }
    }
}

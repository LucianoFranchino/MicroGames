using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float ballSpeed = 100f;
    Vector2 velocity;
    //GameOver
    public GameOverSceen deathMenu;
    void Start()
    {
        velocity.x = Random.Range(1f, -1f);
        velocity.y = 1;
        rb2D.AddForce(velocity * ballSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dead"))
        {
            deathMenu.ActiveScreen();
        }
    }
}

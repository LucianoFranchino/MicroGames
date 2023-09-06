using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float speed = 10f;
    float horizontalMov;

    void Update()
    {
        horizontalMov = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalMov * Time.deltaTime * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour
{

    public float fireBallSpeed;

    void Update()
    {
        transform.position = new Vector2(transform.position.x + fireBallSpeed, transform.position.y + 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
        
        else if(collision.gameObject.tag == "Ground"||collision.gameObject.tag == "MovingGround")
        {
            Destroy(this.gameObject);
        }
    }
}

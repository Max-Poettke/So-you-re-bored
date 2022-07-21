using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed;
    public float size;
    public int state;
    private bool lookingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }


    void Update()
    {
        Move();
    }

    void Move(){
        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed, 0f);

        if(rb.velocity.x > 0){
            lookingRight = true;
            transform.rotation = new Quaternion(0, 0, 0, 0);
        } else if (rb.velocity.x < 0) {
            lookingRight = false;
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
    }
}

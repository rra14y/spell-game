using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerMovment : MonoBehaviour
{
    float horizantolInput;
    float moveSpeed=5f;
    float jumpForse=5f;
    bool  isGrounded=false;

     Rigidbody2D rb;
    Animator  animator;
    // Start is called before the first frame update
    void Start()
    {
      rb=GetComponent<Rigidbody2D>(); 
      animator=GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
      horizantolInput=Input.GetAxis("Horizontal");

    SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

if (horizantolInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizantolInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
      if(Input.GetButtonDown("Jump")&&isGrounded) 

       {
        rb.velocity=new Vector2(rb.velocity.x,jumpForse);
        isGrounded=false;
        }  
    }

   private void FixedUpdate()
   {
    rb.velocity=new Vector2(horizantolInput*moveSpeed,rb.velocity.y);
animator.SetFloat("xVeliocity", Math.Abs(rb.velocity.x));
   }

   private void OnTriggerEnter2D(Collider2D collision)
{
    isGrounded=true;
}

}

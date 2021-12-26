using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   // private bool grounded;
    public float speed = 7;
    private Vector2 startPos;
    bool once = false;
    

    private Animator anim;
    // Start is called before the first frame update

    void Start()
    {

        
      //  grounded = true;
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("w"))
        {
            anim.SetBool("moving", true);

            transform.Translate(-Vector3.forward * -speed * Time.deltaTime);

        }
        if (Input.GetKeyUp("w"))
        {
            anim.SetBool("moving", false);

        }
        if (Input.GetKey("s"))
        {
            anim.SetBool("moving", true);

            transform.Translate(Vector3.forward * -speed * Time.deltaTime);

        }
        if (Input.GetKeyUp("s"))
        {
            anim.SetBool("moving", false);


        }
        if (Input.GetKey("d"))
        {
            anim.SetBool("moving", true);

            transform.Translate(-Vector3.right * -speed * Time.deltaTime);

        }
        if (Input.GetKeyUp("d")) //release button  
        {
            anim.SetBool("moving", false);



        }

      
        if (Input.GetKey("a"))
        {
            anim.SetBool("moving", true);
            transform.Translate(-Vector3.left * -speed * Time.deltaTime);
        }
        if (Input.GetKeyUp("a")) //release button  
        {
            anim.SetBool("moving", false);
            

        }

    }




    private void OnCollisionEnter(Collision collision)
    {
       
    }

  

}
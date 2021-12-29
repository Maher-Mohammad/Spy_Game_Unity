using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   // private bool grounded;
    public float speed = 7;
    private Vector2 startPos;
    bool once = false;
    
    public GameObject camera;


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
        float Xaxis = Input.GetAxis("Horizontal");
        float zaxis = Input.GetAxis("Vertical");


        Vector3 forward = camera.transform.forward;
        Vector3 right = camera.transform.right;
        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();


        Vector3 movementdirection = forward * zaxis + right * Xaxis;
       
        movementdirection.Normalize();
        transform.Translate(movementdirection * speed * Time.deltaTime, Space.World);



        if (movementdirection != Vector3.zero) //rotation part
        {
            transform.forward = movementdirection;
            anim.SetBool("moving", true);
        }

        if (movementdirection == Vector3.zero)
        {
            
            anim.SetBool("moving", false);
        }


    }




    private void OnCollisionEnter(Collision collision)
    {
       
    }

  

}
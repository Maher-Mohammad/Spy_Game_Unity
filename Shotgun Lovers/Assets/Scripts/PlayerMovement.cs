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
        float Xaxis = Input.GetAxis("Horizontal");
        float Yaxis = Input.GetAxis("Vertical");
        Vector3 movementdirection = new Vector3(Xaxis, 0, Yaxis);
        movementdirection.Normalize();
        transform.Translate(movementdirection * speed * Time.deltaTime, Space.Self);
        if (movementdirection != Vector3.zero)
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
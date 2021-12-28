using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Spy_AI : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator anim;
    
    private List<Vector3> cool = new List<Vector3>();
  

    //Patrolling
    public Vector3 walkpoint;
    bool walkpointset = false;
    public float walkpointRange;


    void Start()
    {
        anim.GetComponent<Animator>();
        cool.Add(new Vector3(-10f, 3.48f, -3f));
        cool.Add(new Vector3(-6.39f, 3.48f, -10.72f));
        cool.Add(new Vector3(6.93f, 3.48f, 4.13f));
        cool.Add(new Vector3(2.25f, 3.48f, -13.77f));
        cool.Add(new Vector3(-0.87f, 3.48f, -8.36f));
        cool.Add(new Vector3(-0.87f, 3.48f, -3.45f));
        
      
        agent = GetComponent<NavMeshAgent>(); 
        
    }


    
    
    // Update is called once per frame
    void Update()
    {
        if (!walkpointset)
        { 
            int x = Random.Range(0,5);
            Debug.Log(x);
            walkpoint = cool[x];
            walkpointset = true;

        }
        if (walkpointset)
        {
            agent.SetDestination(walkpoint);
            anim.SetBool("moving", true);
        
        }
        Vector3 distancetowalkpoint = transform.position - walkpoint;

        if (distancetowalkpoint.magnitude < 1f)
        {
            Debug.Log("destination reached");
            anim.SetBool("moving", false);
            walkpointset = false;
           
           
        }

       
    }








}

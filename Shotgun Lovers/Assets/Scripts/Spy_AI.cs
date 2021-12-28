using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Spy_AI : MonoBehaviour
{
    public NavMeshAgent agent;

    
    private List<Vector3> cool = new List<Vector3>();
  

    //Patrolling
    public Vector3 walkpoint;
    bool walkpointset = false;
    public float walkpointRange;


    void Start()
    {
       
        cool.Add(new Vector3(-10f, 3.48f, -3f));
        cool.Add(new Vector3(-6.39f, 3.48f, -10.72f));
        cool.Add(new Vector3(9f, 3.48f, 15f));
        agent = GetComponent<NavMeshAgent>(); 
        
    }


    
    
    // Update is called once per frame
    void Update()
    {
        if (!walkpointset)
        { 
            int x = Random.Range(0, 2);
            Debug.Log(x);
            walkpoint = cool[x];
            walkpointset = true;

        }
        if (walkpointset)
        {
            agent.SetDestination(walkpoint);
        
        }
        Vector3 distancetowalkpoint = transform.position - walkpoint;

        if (distancetowalkpoint.magnitude < 1f)
        {
            Debug.Log("change destination");
            walkpointset = false;
        }
    }








}

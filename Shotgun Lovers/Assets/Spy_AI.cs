using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spy_AI : MonoBehaviour
{

    private bool moving = false;
    private List<Vector3> cool = new List<Vector3>();
    private Vector3 Targetposition;

    

    void Start()
    {
        cool.Add(new Vector3(1f, 0, 3f));
        cool.Add(new Vector3(4f, 0, 6f));
        cool.Add(new Vector3(9f, 0, 15f));
    }



    
    // Update is called once per frame
    void Update()
    {
       int random= Random.Range(1, 3);
        Targetposition = cool[random];

        if (transform.position != Targetposition)
            transform.position = Vector3.MoveTowards(transform.position, Targetposition, 0.005f);
        else
        {
            Targetposition = cool[random];
        }
    }





}

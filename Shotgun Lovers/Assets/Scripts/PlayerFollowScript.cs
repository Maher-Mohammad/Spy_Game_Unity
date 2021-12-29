using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowScript : MonoBehaviour
{
    public float speed = 7;
    public Transform Player;
    public float sensetivity=4f;
    Vector3 distancetoplayer, distancetoplayerD;

    void start()
    { 
    
    distancetoplayerD= (transform.position - Player.position);
    }
    // Update is called once per frame
    void Update()
    {
       
        
        transform.RotateAround(Player.transform.position,new Vector3(0,1f,0), Input.GetAxis("Mouse X")*sensetivity);
      

    }
}

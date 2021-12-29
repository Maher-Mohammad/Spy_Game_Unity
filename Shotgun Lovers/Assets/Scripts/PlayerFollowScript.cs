using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowScript : MonoBehaviour
{
    public Transform Player;
    public float sensetivity=4f;
    // Update is called once per frame
    void Update()
    {
        // Vector3 rotation = new Vector3(0, Input.GetAxis("Mouse X") * 4f, 0);
        transform.position = Player.position + new Vector3(0, 2.558f, -2.1f);
        transform.RotateAround(Player.transform.position,new Vector3(0,1f,0), Input.GetAxis("Mouse X")*sensetivity);
      

    }
}

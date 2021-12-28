using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowScript : MonoBehaviour
{
    public Transform Player;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position+ new Vector3(0, 2.558f, -2.1f);

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerFollower : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;
 

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position+offset;
        //transform.rotation = player.rotation ;
       
    }
  
}


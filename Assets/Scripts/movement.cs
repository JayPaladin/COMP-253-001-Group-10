﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
   


void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;
        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);
		
    }
}

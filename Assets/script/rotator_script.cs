﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator_script : MonoBehaviour
{
    public float speed = 100f;
    private void Update()
    {
        transform.Rotate(0f,0f,speed*Time.deltaTime);
    }
}

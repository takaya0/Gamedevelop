﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startshot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(30, 100), 0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

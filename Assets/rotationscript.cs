﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(2, 10 * Time.deltaTime, 0);
	}
}

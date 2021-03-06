﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

    public enum direccionFlecha { right, left, up, down };
    public direccionFlecha selectedDirection;
    public float timeToDestroy;
    public bool RunDestroyTimer = false;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update() {
        if (RunDestroyTimer)
            timeToDestroy -= Time.deltaTime;

        if (timeToDestroy <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Bee1" || col.gameObject.name == "Bee2")
        {
            switch (selectedDirection)
            {
                case direccionFlecha.right:
                    col.GetComponent<BeeScript>().currentDirection = BeeScript.Direction.right;
                    break;
                case direccionFlecha.up:
                    col.GetComponent<BeeScript>().currentDirection = BeeScript.Direction.up;
                    break;
                case direccionFlecha.down:
                    col.GetComponent<BeeScript>().currentDirection = BeeScript.Direction.down;
                    break;
                case direccionFlecha.left:
                    col.GetComponent<BeeScript>().currentDirection = BeeScript.Direction.left;
                    break;
            }
            Destroy(this.gameObject);
        }
    }
}

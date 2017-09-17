﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Move : MonoBehaviour {


	int movePoint_x;
	int movePoint_z;
	public int speed=1;
	// Use this for initialization
	void Start () {
		movePoint_x = Random.Range (-37,37);
		movePoint_z = Random.Range (24,33);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x >movePoint_x+1||this.transform.position.x <movePoint_x-1) {
			if (this.transform.position.x > movePoint_x) {
				this.transform.Translate (new Vector3 (1, 0, 0) * -1 * speed * Time.deltaTime);
			}
			if (this.transform.position.x < movePoint_x) {
				this.transform.Translate
				(new Vector3 (1, 0, 0) * speed * Time.deltaTime*Time.timeScale);
			}
		} else {
			movePoint_x = Random.Range (-37,37);
		}

		if (this.transform.position.z >movePoint_z+1||this.transform.position.z <movePoint_z-1) {
			if (this.transform.position.z > movePoint_z) {
				this.transform.Translate (new Vector3 (0, 0, 1) * -1 * speed * Time.deltaTime);
			}
			if (this.transform.position.z < movePoint_z) {
				this.transform.Translate
				(new Vector3 (0, 0, 1) * speed * Time.deltaTime*Time.timeScale);
			}
		} else {
			movePoint_z = Random.Range (24,33);
		}
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet : MonoBehaviour {

	public float speed;
	public int damage;
	public int destroy_pos;

	// Update is called once per frame
	void Update () {

		if (this.transform.position.z > destroy_pos) {
			Destroy (this.gameObject);
		}
		this.transform.Translate(new Vector3 (0, 0, 1) * Time.deltaTime * speed*Time.timeScale);

	}
}

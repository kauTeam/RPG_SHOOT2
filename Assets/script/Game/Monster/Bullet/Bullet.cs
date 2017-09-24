using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed=13f;
	public GameObject bullet;
	public int type=1;
	public int damage = 30;
	public float target_x;
	public float target_z;
	public float direction;
	public bool down = true;	
	// Use this for initialization
	void Start () {
		direction = (target_x - this.transform.position.x) / (this.transform.position.z - target_z);
	}
	
	// Update is called once per frame
	void Update () {

		//직선탄
		if (type == 1) {
			this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}

		// 대각탄
		if (type == 2) {
			this.transform.Translate (new Vector3 (-0.2f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 3) {
			this.transform.Translate (new Vector3 (0.2f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 4) {
			this.transform.Translate (new Vector3 (-0.4f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 5) {
			this.transform.Translate (new Vector3 (0.4f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 6) {
			this.transform.Translate (new Vector3 (-0.6f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 7) {
			this.transform.Translate (new Vector3 (0.6f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 8) {
			this.transform.Translate (new Vector3 (-0.8f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 9) {
			this.transform.Translate (new Vector3 (0.8f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 10) {
			this.transform.Translate (new Vector3 (-1, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 11) {
			this.transform.Translate (new Vector3 (1, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 12) {
			this.transform.Translate (new Vector3 (-0.2f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 13) {
			this.transform.Translate (new Vector3 (0.2f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 14) {
			this.transform.Translate (new Vector3 (-0.4f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 15) {
			this.transform.Translate (new Vector3 (0.4f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 16) {
			this.transform.Translate (new Vector3 (-0.6f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 17) {
			this.transform.Translate (new Vector3 (0.6f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 18) {
			this.transform.Translate (new Vector3 (-0.8f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 19) {
			this.transform.Translate (new Vector3 (0.8f, 0, 1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 20) {
			this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime*Time.timeScale);
			if (this.transform.position.z<15&&this.transform.position.z>14.7f) {

				for (int i = 0; i < 19; i++) {
					GameObject tan = Instantiate (this.gameObject, this.gameObject.transform.position, this.gameObject.transform.rotation);
					tan.GetComponent<Bullet> ().setType (i+2);
					tan.GetComponent<Bullet> ().setDamage (damage);
					tan.GetComponent<Bullet> ().setSpeed ((int)speed);
				}
			}
		}

		if (type == 21) {
			this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime*Time.timeScale);
			if (this.transform.position.z<5&&this.transform.position.z>4.8f) {

				for (int i = 10; i < 19; i++) {
					GameObject tan = Instantiate (this.gameObject, this.gameObject.transform.position, this.gameObject.transform.rotation);
					tan.GetComponent<Bullet> ().setType (i+2);
					tan.GetComponent<Bullet> ().setDamage (damage);
					tan.GetComponent<Bullet> ().setSpeed ((int)speed);
				}
			}
		}

		if (type == 22) {
			this.transform.Translate (new Vector3 (0, 0, -1) * speed * Time.deltaTime*Time.timeScale);
			if (this.transform.position.z<10&&this.transform.position.z>9.6f) {

				for (int i = 0; i < 6; i++) {
					GameObject tan = Instantiate (this.gameObject, this.gameObject.transform.position, this.gameObject.transform.rotation);
					tan.GetComponent<Bullet> ().setType (i+2);
					tan.GetComponent<Bullet> ().setDamage (damage);
					tan.GetComponent<Bullet> ().setSpeed ((int)speed);
				}
			}
		}

		if (type == 24) {
			this.transform.Translate (new Vector3 (direction, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}


		if (type == 31) {
			this.transform.Translate (new Vector3 (-0.1f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 32) {
			this.transform.Translate (new Vector3 (0.1f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 33) {
			this.transform.Translate (new Vector3 (-0.3f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 34) {
			this.transform.Translate (new Vector3 (0.3f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 35) {
			this.transform.Translate (new Vector3 (-0.5f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 36) {
			this.transform.Translate (new Vector3 (0.5f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 37) {
			this.transform.Translate (new Vector3 (-0.7f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 38) {
			this.transform.Translate (new Vector3 (0.7f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 39) {
			this.transform.Translate (new Vector3 (-0.9f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}
		if (type == 40) {
			this.transform.Translate (new Vector3 (0.9f, 0, -1) * speed * Time.deltaTime*Time.timeScale);
		}




		if (this.transform.position.z < -20||this.transform.position.z > 46||this.transform.position.x< -37||this.transform.position.x > 37) {
			Destroy (this.gameObject);
		}

	}

	public void setTarget(float x,float z)
	{
		target_x = x;
		target_z = z;
		direction = (target_x - this.transform.position.x) / (this.transform.position.z - target_z);
	}
	public void setType(int x)
	{
		type = x;
	}
	public void setSpeed(int x)

	{
		speed = (float)x;
	}
	public int getDamage()
	{
		return damage;
	}
	public void setDamage(int x)
	{
		damage = x;
	}public void setScale(float x, float y, float z)
	{
		this.transform.localScale+= new Vector3 (x, y, z);
	}
}

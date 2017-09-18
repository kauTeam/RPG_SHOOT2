using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_shoot : MonoBehaviour {

	public GameObject bullet;
	public Transform pos;
	public int Max_tan=35;
	int Now_tan=35;
	public int damage;
	public float speed;
	public float reroad_delay=1f;
	public GameObject reroad_text;
	public Text bullet_text;
	bool shoot_state=true;
	// Use this for initialization


	void Awake()
	{
		Now_tan = Max_tan;
		bullet_text = bullet_text.GetComponent<Text> ();
		bullet_text.text = Now_tan.ToString () + " / " + Max_tan.ToString ();
	}

	void Update()
	{
	}

	public void shoot()
	{
		if (shoot_state) {
			
			Now_tan = Now_tan - 1;
			if (Now_tan == 0) {
				shoot_state = false;
				reroad ();
			}
			bullet_text.text = Now_tan.ToString () + " / " + Max_tan.ToString ();
			GameObject tan = Instantiate (bullet, pos.position, pos.rotation);
			tan.GetComponent<Player_Bullet> ().setDamage (damage);
			tan.GetComponent<Player_Bullet> ().setSpeed (speed);

		} 
	}
	public void reroad()
	{
		shoot_state = false;
		reroad_text.SetActive (true);
		Invoke ("charge", reroad_delay);
		
	}
	public  void charge()
	{
		
		reroad_text.SetActive (false);
		Now_tan = Max_tan;
		bullet_text.text = Now_tan.ToString () + " / " + Max_tan.ToString ();
		shoot_state = true;

	}
}



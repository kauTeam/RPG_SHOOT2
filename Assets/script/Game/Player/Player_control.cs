using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_control : MonoBehaviour {



	int character;
	// Use this for initialization
	void Start () {
			
	}

	void Awake()
	{
		character = PlayerPrefs.GetInt ("now_character");
	}

	public int get_Now_HP()
	{
		if (this.transform.Find (character.ToString ()) != null) {
			return this.gameObject.transform.Find (character.ToString ()).gameObject.GetComponent<Player_Status> ().get_Now_HP ();
		} else {
			Destroy(this.gameObject);
			return 0;
		}

	}
	public int get_Max_HP()
	{
		if (this.transform.Find (character.ToString ()) != null) {
			return this.transform.Find (character.ToString ()).gameObject.GetComponent<Player_Status> ().get_Max_HP ();
		} else {
			Destroy(this.gameObject);
			return 10;
		}
	}
	public int get_Now_MP()
	{
		if (this.transform.Find (character.ToString ()) != null) {
			return this.transform.Find (character.ToString ()).gameObject.GetComponent<Player_Status> ().get_Now_MP ();
		} else {
			Destroy(this.gameObject);
			return 0;
		}
	}
	public int get_Max_MP()
	{
		if (this.transform.Find (character.ToString ()) != null) {			
			return this.transform.Find (character.ToString ()).gameObject.GetComponent<Player_Status> ().get_Max_MP ();
		} else {
			Destroy(this.gameObject);
			return 10;
		}
	}
	public void use()
	{
		this.transform.Find (character.ToString ()).gameObject.GetComponent<Player_Status> ().use ();
	}
	public void shoot()
	{
		this.transform.Find (character.ToString ()).gameObject.GetComponent<Player_shoot> ().shoot ();
	}
	public void reroad()
	{
		this.transform.Find (character.ToString ()).gameObject.GetComponent<Player_shoot> ().reroad ();
		
	}

}

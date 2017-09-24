using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion : MonoBehaviour {

	public GameObject user;
	public int count;
	public Text count_text;
	public int heal_MP;
	public int heal_HP;
	// Use this for initialization
	void Start () {
		count_text = count_text.GetComponent<Text> ();
		count = user.GetComponent<Player_Status> ().count;
	}
	
	// Update is called once per frame
	void Update () {
		count_text.text = count.ToString();
	}

	public void use()
	{
		if (count > 0) {
			count--;
			user.GetComponent<Player_Status> ().use ();
		}
	}
}

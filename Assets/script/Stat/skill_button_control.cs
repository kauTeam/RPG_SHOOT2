using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_button_control : MonoBehaviour {

	public GameObject skill_img;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void attack()
	{
		skill_img.GetComponent<Skill_img_control> ().attack = true;
	}
	public void deffence()
	{
		skill_img.GetComponent<Skill_img_control> ().attack = false;
	}
}

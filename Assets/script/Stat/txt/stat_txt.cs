using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stat_txt : MonoBehaviour {

	// Use this for initialization

	public Text tanchang;
	public Text damage;
	public Text HP;
	public Text MP;
	public Text MP_re;
	public Text SP;
	void Awake()
	{
		tanchang = tanchang.GetComponent<Text> ();
		damage = damage.GetComponent<Text> ();
		HP = HP.GetComponent<Text> ();
		MP = MP.GetComponent<Text> ();
		MP_re = MP_re.GetComponent<Text> ();
		SP = SP.GetComponent<Text> ();
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tanchang.text = PlayerPrefs.GetInt ("bullet_count").ToString () + " / " + PlayerPrefs.GetInt ("max_bullet_count");
		damage.text = PlayerPrefs.GetInt ("damage").ToString () + " / " + PlayerPrefs.GetInt ("max_damage");
		HP.text = PlayerPrefs.GetInt ("hp").ToString () + " / " + PlayerPrefs.GetInt ("max_hp");
		MP.text = PlayerPrefs.GetInt ("mp").ToString () + " / " + PlayerPrefs.GetInt ("max_mp");
		MP_re.text = PlayerPrefs.GetInt ("mp_recover").ToString () + " / " + PlayerPrefs.GetInt ("max_mp_recover");
		SP.text = PlayerPrefs.GetInt ("useful_stat").ToString ();
		
	}
}








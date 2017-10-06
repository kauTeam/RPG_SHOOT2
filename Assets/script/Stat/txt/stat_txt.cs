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
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

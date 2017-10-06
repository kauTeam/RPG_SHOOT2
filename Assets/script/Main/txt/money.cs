using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour {

	public Text money_txt;
	// Use this for initialization
	void Awake()
	{
		money_txt = money_txt.GetComponent<Text> ();
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int mon = PlayerPrefs.GetInt ("money");
		money_txt.text = mon.ToString ();
	}
}

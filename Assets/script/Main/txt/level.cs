using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level : MonoBehaviour {

	public Text level_txt;
	void Awake()
	{
		level_txt = level_txt.GetComponent<Text> ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int lv = PlayerPrefs.GetInt ("level");
		level_txt.text = "LV." + lv.ToString ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class exp_txt : MonoBehaviour {

    public Text exp;
    int lv;
    int now_exp;
	// Use this for initialization
	void Start () {
        exp = exp.GetComponent<Text>();
        lv = PlayerPrefs.GetInt("level");
        now_exp = PlayerPrefs.GetInt("exp");
	}
	
	// Update is called once per frame
	void Update () {
        lv = PlayerPrefs.GetInt("level");
        now_exp = PlayerPrefs.GetInt("exp");
        exp.text = "EXP: "+now_exp.ToString()+"/"+(lv*40+lv*lv*10).ToString();
		
	}
}

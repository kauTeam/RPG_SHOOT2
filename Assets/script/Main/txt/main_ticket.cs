using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class main_ticket : MonoBehaviour {

    public Text text;
	// Use this for initialization
	void Start () {
        text = text.GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = PlayerPrefs.GetInt("ticket").ToString();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name : MonoBehaviour {

	public Text name_txt;
	// Use this for initialization
	void Start () {
		
	}
	void Awake()
	{
		name_txt = name_txt.GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		switch(PlayerPrefs.GetInt("now_character"))
		{
		case 0:
			name_txt.text="모험가";
			break;
		case 1:
			name_txt.text="냥아치";
			break;
		case 2:
			name_txt.text="토쟁이";
			break;
		case 3:
			name_txt.text="펩시";
			break;
		case 4:
			name_txt.text="땡컨";
			break;
		case 5:
			name_txt.text="유히왕";
			break;

		}
		
	}
}

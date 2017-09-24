using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stop : MonoBehaviour {

	public GameObject go;

	public Text count;
	// Use this for initialization
	void Start () {
		count = count.GetComponent<Text> ();
		count.text="Start!";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void time_stop()
	{
		go.SetActive (true);
		Time.timeScale = 0;
	}
	public void time_go()
	{

		Time.timeScale = 1;
		go.SetActive (false);

	}


}

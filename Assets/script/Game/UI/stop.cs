using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stop : MonoBehaviour {

	public GameObject go;

	// Use this for initialization
	void Start () {
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

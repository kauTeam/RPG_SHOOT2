using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_Trans : MonoBehaviour {

	private Text count;
	private float start;
	private float second;
	private float cnt;
	private bool chk;

	// Use this for initialization
	void Start () {
		count = this.gameObject.GetComponentInChildren<Text> ();
		Time.timeScale = 0;
		start = Time.realtimeSinceStartup;
		//StartCoroutine ("Get_Count");
		cnt = 3;
		chk = true;
	}

	void Awake(){
		Time.timeScale = 0;
	}

	// Update is called once per frame
	void Update () {
		if (chk) {
			Time.timeScale = 0;
			second = Time.realtimeSinceStartup - start;
			start = Time.realtimeSinceStartup;
			cnt -= second;
			if (cnt <= 0.0f) {
				chk = false;
			}
			else if (cnt <= 1.0f) {
				count.text = "GO!";
			} else {
				count.text = get_string (cnt);
			}
		} else {
			Destroy (this.gameObject);
			Time.timeScale = 1;
		}
	}

	string get_string(float data){
		return string.Format("{0:f0}",data);
	}

	IEnumerator Get_Count(){

		for (float a = 3; a >= 0; a -= 1.0f) {
			if (a == 0.0f) {
				count.text = "GO!";
			} else {
				count.text = get_string (a);
			}
			yield return new WaitForSeconds (1.0f);
		}

		Destroy (this.gameObject);
		//Time.timeScale = 1;
	}
}

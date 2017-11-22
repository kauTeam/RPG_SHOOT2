using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count_Trans : MonoBehaviour {

	private Text count;

	// Use this for initialization
	void Start () {
		count = this.gameObject.GetComponentInChildren<Text> ();
		Time.timeScale = 0;
		StartCoroutine ("Get_Count");
	}

	void Awake(){
		Time.timeScale = 0;
	}

	// Update is called once per frame
	void Update () {

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

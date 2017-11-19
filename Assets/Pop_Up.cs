using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pop_Up : MonoBehaviour {

	public Text dmg_txt;
	public Transform monster_pos;

	private Vector3  v;
	private int damage;
	// Use this for initialization
	void Start () {
		print ("start");
		dmg_txt = this.GetComponentInChildren<Text> ();
		damage= PlayerPrefs.GetInt("damage");
		dmg_txt.text = "-"+damage.ToString();
		StartCoroutine ("get_Damage");
	}
	
	// Update is called once per frame
	void Update () {
		dmg_txt.rectTransform.Translate (0, 0.05f * Time.deltaTime * Time.timeScale, 0);
	}

	IEnumerator get_Damage(){

		for (float a = 1; a >= 0; a -= 0.1f) {
			Color tmp = dmg_txt.color;
			tmp.a = a;
			dmg_txt.color = tmp;
			yield return new WaitForSeconds (0.05f);
		}

		Destroy (this.gameObject);
	}

}

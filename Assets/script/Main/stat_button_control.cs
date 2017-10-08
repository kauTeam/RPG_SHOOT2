using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stat_button_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void tanchang()
	{
		int now = PlayerPrefs.GetInt ("bullet_count");
		int sp = PlayerPrefs.GetInt ("useful_stat");
		int max = PlayerPrefs.GetInt ("max_bullet_count");
		if ((now < max)&&(sp>0)) {
			sp -= 1;
			PlayerPrefs.SetInt("useful_stat",sp);
			PlayerPrefs.SetInt ("bullet_count",now+1);
		}
	}
	public void hp()
	{
		int now = PlayerPrefs.GetInt ("hp");
		int sp = PlayerPrefs.GetInt ("useful_stat");
		int max = PlayerPrefs.GetInt ("max_hp");
		if ((now < max)&&(sp>0)) {
			sp -= 1;
			PlayerPrefs.SetInt("useful_stat",sp);
			PlayerPrefs.SetInt ("hp",now+5);
		}
	}
	public void mp()
	{

		int now = PlayerPrefs.GetInt ("mp");
		int sp = PlayerPrefs.GetInt ("useful_stat");
		int max = PlayerPrefs.GetInt ("max_mp");
		if ((now < max)&&(sp>0)) {
			sp -= 1;
			PlayerPrefs.SetInt("useful_stat",sp);
			PlayerPrefs.SetInt ("mp",now+5);
		}
	}
	public void mp_re()
	{
		int now = PlayerPrefs.GetInt ("mp_recover");
		int sp = PlayerPrefs.GetInt ("useful_stat");
		int max = PlayerPrefs.GetInt ("max_mp_recover");
		if ((now < max)&&(sp>0)) {
			sp -= 1;
			PlayerPrefs.SetInt("useful_stat",sp);
			PlayerPrefs.SetInt ("mp_recover",now+1);
		}
	}
	public void damage()
	{
		int now = PlayerPrefs.GetInt ("damage");
		int sp = PlayerPrefs.GetInt ("useful_stat");
		int max = PlayerPrefs.GetInt ("max_damage");
		print ("damage");
		if ((now < max)&&(sp>0)) {
			sp -= 1;
			PlayerPrefs.SetInt("useful_stat",sp);
			PlayerPrefs.SetInt ("damage",now+1);
		}
	}
}

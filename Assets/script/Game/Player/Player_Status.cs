using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Status : MonoBehaviour {

	public Text count_text;
	public int Max_HP;
	public int Max_MP;
	int Now_HP;
	int Now_Mp;
	public int Mp_Recover;
	public int count;
	public int Heal_HP;
	public int Heal_MP;
	bool Mp_Cover_state=true;
	// Use this for initialization
	void Start () {
		Max_HP = PlayerPrefs.GetInt ("hp");
		Max_MP = PlayerPrefs.GetInt ("mp");
		Mp_Recover = PlayerPrefs.GetInt ("mp_recover");
		Now_HP = Max_HP;
		Now_Mp = Max_MP;
		count_text = count_text.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Mp_Cover_state) {
			Invoke ("MP_Cover", 1f);
			Mp_Cover_state = false;
			Now_Mp += Mp_Recover;
			if (Now_Mp > Max_MP) {
				Now_Mp = Max_MP;
			}
			
		}
		count_text.text = count.ToString ();
	}

	void MP_Cover()
	{
		Mp_Cover_state = true;
	}

	void OnTriggerEnter(Collider tan)
	{

		if (tan.tag == "enemy_bullet") {
			
			Now_HP -= tan.gameObject.GetComponent<Bullet> ().getDamage ();
			Destroy (tan.gameObject);
			if (Now_HP <= 0) {
				Destroy (this.gameObject);
			}
		}
        if(tan.tag=="ticket")
        {
            int count = PlayerPrefs.GetInt("ticket");
            PlayerPrefs.SetInt("ticket", count + 1);
            Destroy(tan.gameObject);
        }
	}

	public int get_Now_HP()
	{
		return Now_HP;
	}
	public int get_Max_HP()
	{
		return Max_HP;
	}
	public int get_Now_MP()
	{
		return Now_Mp;
	}
	public int get_Max_MP()
	{
		return Max_MP;
	}
    public void use_mp(int x)
    {
        Now_Mp -= x;
    }

	public void use()
	{
		if (count>0) {
			count--;
			Now_HP += Heal_HP;
			if (Now_HP > Max_HP) {
				Now_HP = Max_HP;
			}

			Now_Mp+= Heal_MP;
			if ( Now_Mp > Max_MP) {
				Now_Mp = Max_MP;
			}
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster_Status : MonoBehaviour {

    public GameObject ticket;
    public Transform pos;
	public int Max_HP;

	public GameObject dmg;
	int Now_HP;

	bool attacked;
	// Use this for initialization
	void Start () {
		attacked = false;
		Now_HP = Max_HP;
	}

	public float get_Now_HP()
	{
		return Now_HP;
	}
	public int get_Max_HP()
	{
		return Max_HP;
	}
	void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "player_bullet") {
			Now_HP -= tan.gameObject.GetComponent<Player_Bullet> ().getDamage ();
			Destroy (tan.gameObject);
			attacked = true;
		}
	}
    public void get_damage(int damage)
    {
        Now_HP -= damage;
    }
	// Update is called once per frame
	void Update () {
		if (attacked) {
			print ("attacked");
			Vector3 v=new Vector3 (this.gameObject.transform.position.x + 5, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
			Instantiate (dmg, v, Quaternion.identity);
			attacked = false;
		}

        if (Now_HP <= 0)
        {
            if (1 == Random.Range(1, 20))
            {
                Instantiate(ticket, pos.position, pos.rotation);
            }

            Destroy(this.gameObject);
        }
    }


}

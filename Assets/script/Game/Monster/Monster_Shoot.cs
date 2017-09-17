using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Shoot : MonoBehaviour {



	public GameObject miss1 = null;

	public Transform shoot_pos = null;
	public Transform target_pos = null;
	public float attack_speed=1f;
	public int damage=20;
	public int speed = 1;
	public int[] tan_speed = new int[5] ;
	public bool[] type=new bool[9];
	public int type_count=0;
	int[] vc=new int[9];
	bool shoot_state=true;


	// Update is called once per frame

	void Awake()
	{
		for (int i = 0; i < type.Length; i++) {
			if (type [i]) {
				vc [type_count] = i;
				type_count++;
			}
		}
	}
	// Use this for initialization
	void Start () {
		
		
	}
	
	void Update () 
	{
		if (shoot_state) 
		{
			Invoke ("set_shoot_state", attack_speed);

			int pattern = Random.Range (0, type_count);
			switch (vc [pattern]) {

			case 0:
				{
					StartCoroutine (normal_bullet(1,1,0f));
					StartCoroutine (normal_bullet(1,1,0.5f));
					StartCoroutine (normal_bullet(1,1,1f));
					StartCoroutine (normal_bullet(4,1,0f));
					StartCoroutine (normal_bullet(4,1,0.5f));
					StartCoroutine (normal_bullet(4,1,1f));
					StartCoroutine (normal_bullet(5,1,0f));
					StartCoroutine (normal_bullet(5,1,0.5f));
					StartCoroutine (normal_bullet(5,1,1f));
					break;
				}
			case 1:
				{
					StartCoroutine (lockOn_bullet(3,0));
					StartCoroutine (lockOn_bullet(3,0.4f));
					StartCoroutine (lockOn_bullet(3,0.8f));

					break;
				}
			case 2:
				{
					StartCoroutine (normal_bullet(21,1,0f));

					break;
				}
			case 3:
				{
					StartCoroutine (normal_bullet(22,1,0f));

					break;
				}
			case 4:
				{
					StartCoroutine (normal_bullet(20,1,0f));

					break;
				}
			case 5:
				{
					break;
				}
			case 6:
				{
					break;
				}
			case 7:
				{
					break;
				}
			case 8:
				{
					break;
				}
			case 9:
				{
					break;
				}
			case 10:
				{
					break;
				}
			case 11:
				{
					break;
				}
			case 12:
				{
					break;
				}
			case 13:
				{
					break;
				}
			case 14:
				{
					break;
				}
			case 15:
				{
					break;
				}
			case 16:
				{
					break;
				}
			case 17:
				{
					break;
				}
			case 18:
				{
					break;
				}
			case 19:
				{
					
					break;
				}
			}
				

			shoot_state = false;

		}
	}

	IEnumerator normal_bullet(int type,int speed, float delay)
	{
		yield return new WaitForSeconds (delay);
		GameObject tan=Instantiate (miss1, shoot_pos.position, shoot_pos.rotation);
		tan.GetComponent<Bullet>().setType (type);
		tan.GetComponent<Bullet>().setDamage (damage);
		tan.GetComponent<Bullet> ().setSpeed (tan_speed[speed]);
	}

	IEnumerator lockOn_bullet(int speed,float delay)
	{
		yield return new WaitForSeconds (delay);
		GameObject tan=Instantiate (miss1, shoot_pos.position, shoot_pos.rotation);
		tan.GetComponent<Bullet>().setType (24);
		tan.GetComponent<Bullet>().setDamage (damage);
		tan.GetComponent<Bullet> ().setTarget (target_pos.position.x, target_pos.position.z);
		print (target_pos.position.x);
		print (target_pos.position.z);
		tan.GetComponent<Bullet> ().setSpeed (tan_speed[speed]);
	}

	void set_shoot_state()
	{
		shoot_state = true;
	}
}

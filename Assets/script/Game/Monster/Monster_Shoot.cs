using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Shoot : MonoBehaviour {



	public GameObject miss1 = null;
    public GameObject target = null;


    public Transform shoot_pos = null;
    int character;
    Transform target_pos = null;
	float target_x;
	float target_z;
	public float attack_speed=1f;
	public int damage;
	public int speed;
	public int[] tan_speed = new int[7] ;
	public bool[] type=new bool[16];
	public int type_count=0;
	int[] vc=new int[16];
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
        character = PlayerPrefs.GetInt("now_character");
    }
	// Use this for initialization
	void Start () {
        character = PlayerPrefs.GetInt("now_character");

    }
	
	void Update () 
	{
		if (shoot_state) 
		{
			Invoke ("set_shoot_state", attack_speed);

			int pattern = Random.Range (0, type_count);
			switch (vc [pattern]) {
			// 3개방향 직진 3단 탄
			case 0:
				{
					StartCoroutine (normal_bullet(1,1,0f));
					StartCoroutine (normal_bullet(1,1,0.4f));
					StartCoroutine (normal_bullet(1,1,0.8f));
					StartCoroutine (normal_bullet(6,1,0f));
					StartCoroutine (normal_bullet(6,1,0.4f));
					StartCoroutine (normal_bullet(6,1,0.8f));
					StartCoroutine (normal_bullet(7,1,0f));
					StartCoroutine (normal_bullet(7,1,0.4f));
					StartCoroutine (normal_bullet(7,1,0.8f));
					break;
				}
				//유탄 3개 
			case 1:
				{
					StartCoroutine (lockOn_bullet(3,0));
					StartCoroutine (lockOn_bullet(3,0.3f));
					StartCoroutine (lockOn_bullet(3,0.6f));

					break;
				}
				//위로 퍼짐 탄
			case 2:
				{
					StartCoroutine (normal_bullet(21,1,0f));

					break;
				}
				//아래로 퍼짐탄
			case 3:
				{
					StartCoroutine (normal_bullet(22,1,0f));

					break;
				}
				//다 퍼짐 탄
			case 4:
				{
					StartCoroutine (normal_bullet(20,1,0f));

					break;
				}
				//5갈래 퍼짐 탄 
			case 5:
				{
					StartCoroutine (normal_bullet(1,3,0f));
					StartCoroutine (normal_bullet(1,3,0.5f));
					StartCoroutine (normal_bullet(1,3,1f));
					StartCoroutine (normal_bullet(4,3,0f));
					StartCoroutine (normal_bullet(4,3,0.5f));
					StartCoroutine (normal_bullet(4,3,1f));
					StartCoroutine (normal_bullet(5,3,0f));
					StartCoroutine (normal_bullet(5,3,0.5f));
					StartCoroutine (normal_bullet(5,3,1f));
					StartCoroutine (normal_bullet(2,3,0f));
					StartCoroutine (normal_bullet(2,3,0.5f));
					StartCoroutine (normal_bullet(2,3,1f));
					StartCoroutine (normal_bullet(3,3,0f));
					StartCoroutine (normal_bullet(3,3,0.5f));
					StartCoroutine (normal_bullet(3,3,1f));

					break;
				}

				//S자 퍼짐
			case 6:
				{
					StartCoroutine (normal_bullet(9,1,0f));
					StartCoroutine (normal_bullet(7,1,0.1f));
					StartCoroutine (normal_bullet(5,1,0.2f));
					StartCoroutine (normal_bullet(3,1,0.3f));
					StartCoroutine (normal_bullet(1,1,0.4f));
					StartCoroutine (normal_bullet(2,1,0.5f));
					StartCoroutine (normal_bullet(4,1,0.6f));
					StartCoroutine (normal_bullet(6,1,0.7f));
					StartCoroutine (normal_bullet(8,1,0.8f));
					StartCoroutine (normal_bullet(9,1,1.6f));
					StartCoroutine (normal_bullet(7,1,1.5f));
					StartCoroutine (normal_bullet(5,1,1.4f));
					StartCoroutine (normal_bullet(3,1,1.3f));
					StartCoroutine (normal_bullet(1,1,1.2f));
					StartCoroutine (normal_bullet(2,1,1.1f));
					StartCoroutine (normal_bullet(4,1,1f));
					StartCoroutine (normal_bullet(6,1,0.9f));  
					break;
				}
				//격자1 
			case 7:
				{
					StartCoroutine (normal_bullet(1,0,0f));
					StartCoroutine (normal_bullet(1,0,0.4f));
					StartCoroutine (normal_bullet(1,0,0.8f));
					StartCoroutine (normal_bullet(1,0,1.2f));

					StartCoroutine (normal_bullet(4,0,0f));
					StartCoroutine (normal_bullet(4,0,0.4f));
					StartCoroutine (normal_bullet(4,0,0.8f));
					StartCoroutine (normal_bullet(4,0,1.2f));

					StartCoroutine (normal_bullet(5,0,0f));
					StartCoroutine (normal_bullet(5,0,0.4f));
					StartCoroutine (normal_bullet(5,0,0.8f));
					StartCoroutine (normal_bullet(5,0,1.2f));

					StartCoroutine (normal_bullet(8,0,0f));
					StartCoroutine (normal_bullet(8,0,0.4f));
					StartCoroutine (normal_bullet(8,0,0.8f));
					StartCoroutine (normal_bullet(8,0,1.2f));

					StartCoroutine (normal_bullet(9,0,0f));
					StartCoroutine (normal_bullet(9,0,0.4f));
					StartCoroutine (normal_bullet(9,0,0.8f));
					StartCoroutine (normal_bullet(9,0,1.2f));

					StartCoroutine (normal_bullet(2,0,0.2f));
					StartCoroutine (normal_bullet(2,0,0.6f));
					StartCoroutine (normal_bullet(2,0,1f));

					StartCoroutine (normal_bullet(3,0,0.2f));
					StartCoroutine (normal_bullet(3,0,0.6f));
					StartCoroutine (normal_bullet(3,0,1f));

					StartCoroutine (normal_bullet(6,0,0.2f));
					StartCoroutine (normal_bullet(6,0,0.6f));
					StartCoroutine (normal_bullet(6,0,1f));

					StartCoroutine (normal_bullet(7,0,0.2f));
					StartCoroutine (normal_bullet(7,0,0.6f));
					StartCoroutine (normal_bullet(7,0,1f));


					break;
				}
				//4개 큰 총알
			case 8:
				{
					StartCoroutine (big_bullet (2, 5, 0f, 2));
					StartCoroutine (big_bullet (3, 5, 0f, 2));
					StartCoroutine (big_bullet (8, 5, 0f, 2));
					StartCoroutine (big_bullet (9, 5, 0f, 2));

					break;
				}
				//대빵 큰 느린거
			case 9:
				{
					StartCoroutine (big_bullet (1, 4, 0f, 3));

					break;
				}
				//직선탄 개빠름 3단 
			case 10:
				{
					StartCoroutine (normal_bullet (1, 6, 0f));
					StartCoroutine (normal_bullet (1, 6, 0.2f));
					StartCoroutine (normal_bullet (1, 6, 0.4f));

					break;
				}
				//커튼
			case 11:
				{
					StartCoroutine (normal_bullet (9, 0, 0f));
					StartCoroutine (normal_bullet (8, 0, 0f));
					StartCoroutine (normal_bullet (7, 1, 0.0f));
					StartCoroutine (normal_bullet (6, 1, 0.0f));
					StartCoroutine (normal_bullet (5, 2, 0.0f));
					StartCoroutine (normal_bullet (4, 2, 0.0f));
					StartCoroutine (normal_bullet (3, 3, 0.0f));
					StartCoroutine (normal_bullet (2, 3, 0.0f));
					StartCoroutine (normal_bullet (1, 3, 0.05f));

					StartCoroutine (normal_bullet (9, 0, 0.25f));
					StartCoroutine (normal_bullet (8, 0, 0.25f));
					StartCoroutine (normal_bullet (7, 1, 0.25f));
					StartCoroutine (normal_bullet (6, 1, 0.25f));
					StartCoroutine (normal_bullet (5, 2, 0.25f));
					StartCoroutine (normal_bullet (4, 2, 0.25f));
					StartCoroutine (normal_bullet (3, 3, 0.25f));
					StartCoroutine (normal_bullet (2, 3, 0.25f));
					StartCoroutine (normal_bullet (1, 3, 0.3f));

					StartCoroutine (normal_bullet (9, 0, 0.5f));
					StartCoroutine (normal_bullet (8, 0, 0.5f));
					StartCoroutine (normal_bullet (7, 1, 0.5f));
					StartCoroutine (normal_bullet (6, 1, 0.5f));
					StartCoroutine (normal_bullet (5, 2, 0.5f));
					StartCoroutine (normal_bullet (4, 2, 0.5f));
					StartCoroutine (normal_bullet (3, 3, 0.5f));
					StartCoroutine (normal_bullet (2, 3, 0.5f));
					StartCoroutine (normal_bullet (1, 3, 0.55f));


					break;
				}
				// 격자 2
			case 12:
				{
					StartCoroutine (normal_bullet(1,3,0f));
					StartCoroutine (normal_bullet(1,2,0.4f));
					StartCoroutine (normal_bullet(1,1,0.8f));
					StartCoroutine (normal_bullet(1,1,1.2f));

					StartCoroutine (normal_bullet(4,3,0f));
					StartCoroutine (normal_bullet(4,2,0.4f));
					StartCoroutine (normal_bullet(4,1,0.8f));
					StartCoroutine (normal_bullet(4,1,1.2f));

					StartCoroutine (normal_bullet(5,3,0f));
					StartCoroutine (normal_bullet(5,2,0.4f));
					StartCoroutine (normal_bullet(5,1,0.8f));
					StartCoroutine (normal_bullet(5,1,1.2f));

					StartCoroutine (normal_bullet(8,3,0f));
					StartCoroutine (normal_bullet(8,2,0.4f));
					StartCoroutine (normal_bullet(8,1,0.8f));
					StartCoroutine (normal_bullet(8,1,1.2f));

					StartCoroutine (normal_bullet(9,3,0f));
					StartCoroutine (normal_bullet(9,2,0.4f));
					StartCoroutine (normal_bullet(9,1,0.8f));
					StartCoroutine (normal_bullet(9,1,1.2f));

					StartCoroutine (normal_bullet(2,3,0.2f));
					StartCoroutine (normal_bullet(2,2,0.6f));
					StartCoroutine (normal_bullet(2,1,1f));

					StartCoroutine (normal_bullet(3,3,0.2f));
					StartCoroutine (normal_bullet(3,2,0.6f));
					StartCoroutine (normal_bullet(3,1,1f));

					StartCoroutine (normal_bullet(6,3,0.2f));
					StartCoroutine (normal_bullet(6,2,0.6f));
					StartCoroutine (normal_bullet(6,1,1f));

					StartCoroutine (normal_bullet(7,3,0.2f));
					StartCoroutine (normal_bullet(7,2,0.6f));
					StartCoroutine (normal_bullet(7,1,1f));

					break;
				}
				//느린 9개탄
			case 13:
				{
					StartCoroutine (normal_bullet(1,4,0f));
					StartCoroutine (normal_bullet(1,4,0.7f));

					StartCoroutine (normal_bullet(2,4,0f));
					StartCoroutine (normal_bullet(2,4,0.7f));

					StartCoroutine (normal_bullet(3,4,0f));
					StartCoroutine (normal_bullet(3,4,0.7f));

					StartCoroutine (normal_bullet(4,4,0f));
					StartCoroutine (normal_bullet(4,4,0.7f));

					StartCoroutine (normal_bullet(5,4,0f));
					StartCoroutine (normal_bullet(5,4,0.7f));

					StartCoroutine (normal_bullet(6,4,0f));
					StartCoroutine (normal_bullet(6,4,0.7f));

					StartCoroutine (normal_bullet(7,4,0f));
					StartCoroutine (normal_bullet(7,4,0.7f));

					StartCoroutine (normal_bullet(8,4,0f));
					StartCoroutine (normal_bullet(8,4,0.7f));

					StartCoroutine (normal_bullet(9,4,0f));
					StartCoroutine (normal_bullet(9,4,0.7f));

					break;
				}
				//격자 3
			case 14:
				{
					StartCoroutine (normal_bullet(1,4,0f));
					StartCoroutine (normal_bullet(1,4,1.2f));

					StartCoroutine (normal_bullet(2,4,0f));
					StartCoroutine (normal_bullet(2,4,1.2f));

					StartCoroutine (normal_bullet(3,4,0f));
					StartCoroutine (normal_bullet(3,4,1.2f));

					StartCoroutine (normal_bullet(4,4,0f));
					StartCoroutine (normal_bullet(4,4,1.2f));

					StartCoroutine (normal_bullet(5,4,0f));
					StartCoroutine (normal_bullet(5,4,1.2f));

					StartCoroutine (normal_bullet(6,4,0f));
					StartCoroutine (normal_bullet(6,4,1.2f));

					StartCoroutine (normal_bullet(7,4,0f));
					StartCoroutine (normal_bullet(7,4,1.2f));

					StartCoroutine (normal_bullet(8,4,0f));
					StartCoroutine (normal_bullet(8,4,1.2f));

					StartCoroutine (normal_bullet(9,4,0f));
					StartCoroutine (normal_bullet(9,4,1.2f));

					StartCoroutine (normal_bullet(31,4,0.6f));
					StartCoroutine (normal_bullet(32,4,0.6f));
					StartCoroutine (normal_bullet(33,4,0.6f));
					StartCoroutine (normal_bullet(34,4,0.6f));
					StartCoroutine (normal_bullet(35,4,0.6f));
					StartCoroutine (normal_bullet(36,4,0.6f));
					StartCoroutine (normal_bullet(37,4,0.6f));
					StartCoroutine (normal_bullet(38,4,0.6f));
					StartCoroutine (normal_bullet(39,4,0.6f));
					StartCoroutine (normal_bullet(40,4,0.6f));

					StartCoroutine (normal_bullet(31,4,1.8f));
					StartCoroutine (normal_bullet(32,4,1.8f));
					StartCoroutine (normal_bullet(33,4,1.8f));
					StartCoroutine (normal_bullet(34,4,1.8f));
					StartCoroutine (normal_bullet(35,4,1.8f));
					StartCoroutine (normal_bullet(36,4,1.8f));
					StartCoroutine (normal_bullet(37,4,1.8f));
					StartCoroutine (normal_bullet(38,4,1.8f));
					StartCoroutine (normal_bullet(39,4,1.8f));
					StartCoroutine (normal_bullet(40,4,1.8f));

					break;
				}
			case 15:
				{
					StartCoroutine (normal_bullet(1,4,0f));

					StartCoroutine (normal_bullet(2,4,0.1f));
					StartCoroutine (normal_bullet(3,4,0.1f));
					StartCoroutine (normal_bullet(4,4,0.2f));
					StartCoroutine (normal_bullet(5,4,0.2f));
					StartCoroutine (normal_bullet(6,4,0.3f));
					StartCoroutine (normal_bullet(7,4,0.3f));
					StartCoroutine (normal_bullet(8,4,0.4f));
					StartCoroutine (normal_bullet(9,4,0.4f));


					StartCoroutine (normal_bullet(1,4,1f));

					StartCoroutine (normal_bullet(31,4,1.1f));
					StartCoroutine (normal_bullet(32,4,1.1f));
					StartCoroutine (normal_bullet(33,4,1.3f));
					StartCoroutine (normal_bullet(34,4,1.3f));
					StartCoroutine (normal_bullet(35,4,1.5f));
					StartCoroutine (normal_bullet(36,4,1.5f));
					StartCoroutine (normal_bullet(37,4,1.7f));
					StartCoroutine (normal_bullet(38,4,1.7f));
					StartCoroutine (normal_bullet(39,4,1.9f));
					StartCoroutine (normal_bullet(40,4,1.9f));

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

	IEnumerator big_bullet(int type,int speed, float delay,int scale)
	{
		yield return new WaitForSeconds (delay);
		GameObject tan=Instantiate (miss1, shoot_pos.position, shoot_pos.rotation);
		tan.GetComponent<Bullet>().setType (type);
		tan.GetComponent<Bullet>().setDamage (damage*scale);
		tan.GetComponent<Bullet>().setScale (scale,scale,scale);
		tan.GetComponent<Bullet> ().setSpeed (tan_speed[speed]);
	}

	IEnumerator lockOn_bullet(int speed,float delay)
	{
        target_pos=target.transform.Find(character.ToString()).gameObject.transform;

        if (target_pos != null) {
			target_x = target_pos.position.x;
			target_z = target_pos.position.z;
		}
		yield return new WaitForSeconds (delay);
		GameObject tan=Instantiate (miss1, shoot_pos.position, shoot_pos.rotation);
		tan.GetComponent<Bullet>().setType (24);
		tan.GetComponent<Bullet>().setDamage (damage);
		tan.GetComponent<Bullet> ().setTarget (target_x, target_z);
		tan.GetComponent<Bullet> ().setSpeed (tan_speed[speed]);
	}

	void set_shoot_state()
	{
		shoot_state = true;
	}
}

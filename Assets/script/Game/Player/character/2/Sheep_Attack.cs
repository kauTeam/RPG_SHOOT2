using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_Attack : MonoBehaviour {

    public int speed;
    int damage;
	Animator ani;

    // Use this for initialization
    void Start()
    {
		ani = GetComponent<Animator> ();
        damage = PlayerPrefs.GetInt("damage");
    }

    void Awake()
    {
        damage = PlayerPrefs.GetInt("damage");
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0, 0, speed * Time.timeScale * Time.deltaTime);
		ani.SetFloat("move_x",this.gameObject.transform.position.x);
		ani.SetFloat("move_y",this.gameObject.transform.position.z);
        if (this.gameObject.transform.position.z > 45)
        {
            Destroy(this.gameObject);
        }
    }


    void OnTriggerEnter(Collider tan)
    {
        if (tan.tag == "monster")
        {
			Vector3 pos = this.transform.position;
            tan.gameObject.GetComponent<Monster_Status>().get_damage(damage);
            Destroy(this.gameObject);
			GameObject.Find ("Player").GetComponent<use_skill> ().DoHit (pos);
        }
       
    }
		

}

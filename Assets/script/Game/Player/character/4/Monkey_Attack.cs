using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_Attack : MonoBehaviour {

    int damage;
    int angle=-45;
    // Use this for initialization
    void Start () {
        damage = PlayerPrefs.GetInt("damage");
        angle = -45;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.rotation = Quaternion.Euler(90, angle, 0);
        angle++;
        if(angle==45)
        {
            Destroy(this.gameObject);
        }
	}


    void OnTriggerEnter(Collider tan)
    {
        if (tan.tag == "monster")
        {
            tan.gameObject.GetComponent<Monster_Status>().get_damage(damage*3);
        }

    }
}

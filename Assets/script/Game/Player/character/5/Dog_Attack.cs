using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Attack : MonoBehaviour {


    int damage;
    void Start()
    {
        damage = PlayerPrefs.GetInt("damage");
        Invoke("set_Destroy", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Enemy)
    {
        if(Enemy.tag == "monster")
        {
            Enemy.gameObject.GetComponent<Monster_Status>().get_damage(damage);
        }
    }
    void set_Destroy()
    {
        Destroy(this.gameObject);
    }
}

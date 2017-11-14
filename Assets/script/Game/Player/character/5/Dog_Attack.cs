using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Attack : MonoBehaviour {


    int damage;
    int count;
    void Start()
    {
        damage = PlayerPrefs.GetInt("damage");
        Invoke("set_Destroy", 8f);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider Enemy)
    {
        if(Enemy.tag == "monster")
        {
            count++;
            if(count == 40)
            { 
                Enemy.gameObject.GetComponent<Monster_Status>().get_damage(damage);
                count = 0;
            }
        }
    }
    private void OnTriggerEnter(Collider Enemy)
    {
        if (Enemy.tag == "monster")
        {
            Enemy.gameObject.GetComponent<Monster_Status>().get_damage(damage);
        }

    }
    private void OnTriggerExit(Collider Enemy)
    {
        count = 0;
    }
    void set_Destroy()
    {
        Destroy(this.gameObject);
    }
}

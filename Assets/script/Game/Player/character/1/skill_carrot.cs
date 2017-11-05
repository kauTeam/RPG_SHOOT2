using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill_carrot : MonoBehaviour {
    public int speed;
    int damage;

    // Use this for initialization
    void Start()
    {
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
        if (this.gameObject.transform.position.z > 45)
        {
            Destroy(this.gameObject);
        }
    }
    

    void OnTriggerEnter(Collider enemy)
    {
        
        if (enemy.tag == "monster")
        {
            enemy.gameObject.GetComponent<Monster_Status>().get_damage(damage*4);
            Destroy(this.gameObject);
        }
    }
}
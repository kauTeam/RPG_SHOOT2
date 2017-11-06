using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wool_shield : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("set_false", 2f);
        
    }
    private void OnTriggerEnter(Collider tan)
    {
        if (tan.tag == "enemy_bullet")
        {
            Destroy(tan.gameObject);
        }
    }

    void set_false()
    {
        this.gameObject.SetActive(false);
    }
}


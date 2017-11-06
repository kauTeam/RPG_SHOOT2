using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_Shield : MonoBehaviour {
    // Use this for initialization
    int sheild_count = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider tan)
    {
        if (tan.tag == "enemy_bullet")
        {
            Destroy(tan.gameObject);
            sheild_count++;
            if(sheild_count == 10)
            {
                sheild_count = 0;
                this.gameObject.SetActive(false);
            }
        }
    }
}


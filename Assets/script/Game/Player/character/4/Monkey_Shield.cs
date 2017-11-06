using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_Shield : MonoBehaviour {

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
            if (sheild_count == 5)
            {
                sheild_count = 0;
                this.gameObject.SetActive(false);
            }
        }
    }
}


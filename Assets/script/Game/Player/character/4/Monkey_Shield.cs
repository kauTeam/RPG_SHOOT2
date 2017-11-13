using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_Shield : MonoBehaviour {

    int sheild_count = 0;
    public int speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0, 0, speed * Time.timeScale * Time.deltaTime);
        if (this.gameObject.transform.position.z > 18)
        {
            Destroy(this.gameObject);
        }
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


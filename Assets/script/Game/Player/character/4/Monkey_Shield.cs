using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_Shield : MonoBehaviour {

    int sheild_count = 0;
    public int speed;

	Animator ani;

    void Start()
    {
		ani = GetComponent<Animator> ();

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0, 0, speed * Time.timeScale * Time.deltaTime);
		ani.SetFloat ("move_x", this.gameObject.transform.position.x);
		ani.SetFloat ("move_y", this.gameObject.transform.position.z);
        if (this.gameObject.transform.position.z > 18)
        {
			Vector3 pos = this.transform.position;
            Destroy(this.gameObject);
			GameObject.Find ("Player").GetComponent<use_skill> ().DoHit (pos);
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
				Vector3 pos = this.transform.position;
                sheild_count = 0;
                this.gameObject.SetActive(false);
				GameObject.Find ("Player").GetComponent<use_skill> ().DoHit (pos);
            }
        }
    }
}


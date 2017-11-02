using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ticket : MonoBehaviour {



    public int speed = 4;
    int direction=0;
    bool dir = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(this.gameObject.transform.position.z<-10)
        {
            Destroy(this.gameObject);
        }
        if (dir)
        {
            this.gameObject.transform.Translate(1*Time.deltaTime * Time.timeScale, 0, -speed * Time.deltaTime * Time.timeScale);
        }
        else
        {
            this.gameObject.transform.Translate(-1 * Time.deltaTime * Time.timeScale, 0, -speed * Time.deltaTime * Time.timeScale);
        }
        direction++;
        if(direction>30)
        {
            direction = 0;
            dir = !dir;
        }
    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_stage : MonoBehaviour {

    int cur;
    string name;
	// Use this for initialization
	void Awake () {
        print("ddd\n");
        cur = PlayerPrefs.GetInt("cur_stage");
        print(cur);
        for(int i = 2; i < 5; i++)
        {
            string s = i.ToString();
            if (cur < i) break;
            name = s + "stage";
            print(name);
            GameObject.Find(name).transform.GetChild(1).gameObject.SetActive(false);
            GameObject.Find(name).transform.GetChild(0).gameObject.SetActive(true);

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageButton : MonoBehaviour {

    public int stage;
    public int cur_stage;
    //public Image[] ImageArray;
    public Button[] ButtonArray;
    public Sprite EntryImage;
    public Sprite No_EntryImage;
    
	// Use this for initialization
	void Awake () {
        stage = PlayerPrefs.GetInt("stage");
        cur_stage = PlayerPrefs.GetInt("cur_stage");
        print("stage "+cur_stage);

        for(int i=0; i<4; i++)
        {
            if(cur_stage>i)
            {
                ButtonArray[i].image.sprite = EntryImage;
            }
            else
            {
                ButtonArray[i].image.sprite = No_EntryImage;
            }
        }
	}
	// Update is called once per frame
	void Update () {
	
	}
}

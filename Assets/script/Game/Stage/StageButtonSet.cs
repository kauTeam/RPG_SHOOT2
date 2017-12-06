using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageButtonSet : MonoBehaviour {

    public Button[] Stage_Button;
    public Sprite[] SpriteImage;

    public void st(int put_stage)
    {
        int stage = PlayerPrefs.GetInt("stage");
        int current = PlayerPrefs.GetInt("cur_stage");
        int cur_s = stage / 100;
        int cur = stage % 100;
        print("cur " + cur);
        if (put_stage < cur_s)
        {
            for (int i = 0; i < 10; i++)
            {
                Stage_Button[i].image.sprite = SpriteImage[i];
            }
        }
        else
        {
            cur = cur - 1;
            for (int i = 0; i < 10; i++)
            {
              
                if (cur >= i)
                {
                    Stage_Button[i].image.sprite = SpriteImage[i];
                    
                }
                else
                {
                    Stage_Button[i].image.sprite = SpriteImage[10];
                }
            }
        }

    }
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}

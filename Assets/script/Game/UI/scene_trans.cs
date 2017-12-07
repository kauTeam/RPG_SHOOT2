using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class scene_trans : MonoBehaviour {

    Color _fadeColor = new Color(0f, 0f, 0f, 1f);
    int stage;
    int temp_stage1;
    int temp_stage2;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        
    }

    void Awake()
    {
        Time.timeScale = 1;

    }
    // Update is called once per frame
    void Update () {
    }
    public void go_home()
    {
        SceneManager.LoadScene("scene/Main");
    }
    public void Restart()
    {
        int stage=GameObject.Find("Game_Controll").GetComponent<Game_control>().stage;
        print(stage);
        SceneManager.LoadScene("scene/Stage/Stage" + (stage/100).ToString() + "/" + (stage%10).ToString());
    }
    public void Next_Stage()
    {
        int stage = GameObject.Find("Game_Controll").GetComponent<Game_control>().stage;
        print(stage);
        if ((stage % 10) == 0)
        {
            SceneManager.LoadScene("scene/Stage/Stage" + ((stage / 100) + 1).ToString() + "/1" );
        }
        else {
            SceneManager.LoadScene("scene/Stage/Stage" + (stage / 100).ToString() + "/" + ((stage % 10)+1).ToString());
        }
    }
}

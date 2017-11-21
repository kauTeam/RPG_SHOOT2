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
        stage = PlayerPrefs.GetInt("stage");
        if (temp_stage2 == 1)
        {
            stage -= 100;
            stage += 9;
        }
        else
            stage -= 1;
        temp_stage1 = stage / 100;
        temp_stage2 = stage % 100;
        SceneManager.LoadScene("scene/Stage/Stage" + temp_stage1.ToString() + "/" + temp_stage2.ToString());
    }
    public void Next_Stage()
    {
        stage = PlayerPrefs.GetInt("stage");
        temp_stage1 = stage / 100;
        temp_stage2 = stage % 100;
        SceneManager.LoadScene("scene/Stage/Stage" + temp_stage1.ToString() + "/" + temp_stage2.ToString());
    }
}

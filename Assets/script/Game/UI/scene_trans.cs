using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class scene_trans : MonoBehaviour {

    Color _fadeColor = new Color(0f, 0f, 0f, 1f);

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
}

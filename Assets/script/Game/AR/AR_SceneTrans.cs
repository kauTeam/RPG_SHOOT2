using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AR_SceneTrans : MonoBehaviour {

    public void Trans_Win_Main()
    {
        SceneManager.LoadScene("scene/Main");
    }

    public void Trans_Lose_Main()
    {
        SceneManager.LoadScene("scene/Main");
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

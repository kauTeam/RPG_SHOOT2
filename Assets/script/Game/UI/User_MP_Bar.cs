using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_MP_Bar : MonoBehaviour {


    public GameObject user;
    float max_MP;
    float cur_MP;
    public GameObject user_MPBar;
    // Use this for initialization 

    // Update is called once per frame
    void Update()
    {
        decreseMp();
    }

    public void decreseMp()
    {
        if (user != null)
        {
            max_MP = user.gameObject.GetComponent<Player_control>().get_Max_MP();
            cur_MP = user.gameObject.GetComponent<Player_control>().get_Now_MP();
        }
        if (user == null)
        {
            cur_MP = 0;
        }
        float calc_Health = cur_MP / max_MP;
        SetHealthBar(calc_Health);

    }

    public void SetHealthBar(float myHealth)
    {
        user_MPBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f), user_MPBar.transform.localScale.y, user_MPBar.transform.localScale.z);
    }
}

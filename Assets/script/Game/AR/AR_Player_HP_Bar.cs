using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Player_HP_Bar : MonoBehaviour
{

    public GameObject AR_User= null;
    float max_Health;
    float cur_Health;
    public GameObject AR_User_HPBar = null;
    // Use this for initialization 
    void Start()
    {
        max_Health = 5f;
        cur_Health = max_Health;
    }

    // Update is called once per frame
    void Update()
    {
        decreseHealth();
    }

    public void decreseHealth()
    {
        cur_Health = AR_User.GetComponent<AR_Player>().GET_AR_Player_HP();
        float calc_Health = cur_Health / max_Health;
        SetHealthBar(calc_Health);
    }
    
    public void SetHealthBar(float myHealth)
    {
        AR_User_HPBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth/4, 0f, 1f), AR_User_HPBar.transform.localScale.y, AR_User_HPBar.transform.localScale.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube_Shoot : MonoBehaviour {


    public Transform shoot_pos = null;
    void Start () {
		
	}
    // Update is called once per frame
    void Update()
    {
        
    }
     
    public Transform get_shoot_pos()
    {
        return shoot_pos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR_Cube_Bullet : MonoBehaviour {

    public float speed = 13f;
    public GameObject AR_Bullet;
    public int type = 1;
    public int damage = 30;
    public float target_x;
    public float target_z;
    public float pos_x;
    public float pos_z;
    public float direction;
    public bool down = true;
    // Use this for initialization
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x == 0)
        {
            if(this.transform.position.z >= 0)
                this.transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime * Time.timeScale);
            else if (this.transform.position.z <= 0)
                this.transform.Translate(new Vector3(0, 0,  1) * speed * Time.deltaTime * Time.timeScale);
        }
        else if (this.transform.position.z == 0)
        {
            if (this.transform.position.x >= 0)
                this.transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime * Time.timeScale);
            else if (this.transform.position.x <= 0)
                this.transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * Time.timeScale);
        }
        else
        {
            if (this.transform.position.x >= 0 && this.transform.position.z>=0)
            {
                this.transform.Translate(new Vector3(-1, 0, -1) * speed * Time.deltaTime * Time.timeScale);
            }
            else if (this.transform.position.x >= 0 && this.transform.position.z <= 0)
            {
                this.transform.Translate(new Vector3(-1, 0, 1) * speed * Time.deltaTime * Time.timeScale);
            }
            else if (this.transform.position.x <= 0 && this.transform.position.z >= 0)
            {
                this.transform.Translate(new Vector3(1, 0, -1) * speed * Time.deltaTime * Time.timeScale);
            }
            else if (this.transform.position.x <= 0 && this.transform.position.z <= 0)
            {
                this.transform.Translate(new Vector3(1, 0, 1) * speed * Time.deltaTime * Time.timeScale);
            }
        }

    }
    public void setSpeed(int x)

    {
        speed = (float)x;
    }
    public int getDamage()
    {
        return damage;
    }
    public void setDamage(int x)
    {
        damage = x;
    }
    public void setScale(float x, float y, float z)
    {
        this.transform.localScale += new Vector3(x, y, z);
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipBehavior : MonoBehaviour
{

    public Text tt;
    public Text t2;
    public GameObject Meteor;
    public GameObject MeteorSpawn;

    Quaternion startPos;
    Quaternion xxy;
    bool s1 = true;
    bool s2 = true;
    bool ss1 = true;
    bool ss2 = true;
    float timer1 = 0f;
    float timer2 = 0f;

    float yPos = 0;

    int cc = 0;
    int mKills = 5;
    bool meteor = false;


    void Start()
    {
        startPos = transform.rotation;
        yPos = transform.position.y;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (!s2) s2 = true;
            if (ss1)
            {
              
                    timer1 += 1.84f * Time.deltaTime;
            }
            if (transform.eulerAngles.z < 50)
            {
                timer2 = 0;
                
                    transform.Rotate(new Vector3(0, 0, 0.8f + timer1));
                ss1 = true;
            }
            else
            {
                ss1 = false;
            }
            if (s1) transform.position = transform.position + new Vector3(-1, 0, 0) * 32 * Time.deltaTime;

            if (transform.position.x <= -72f)
                s1 = false;
            else s1 = true;
  

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!s1) s1 = true;

            if (ss2) timer2 += 1.84f * Time.deltaTime;
            if (transform.eulerAngles.z >= 300 || transform.eulerAngles.z == 0)
            {
                timer1 = 0;
                transform.Rotate(new Vector3(0, 0, -0.8f - timer2));
                ss2 = true;
            }
            if (s2) transform.position = transform.position + new Vector3(1, 0, 0) * 32 * Time.deltaTime;
            if (transform.position.x >= 58f)
                s2 = false;
            else s2 = true;
        }
        else
        {
            
            timer1 = 0;
            timer2 = 0;
            ss1 = true;
            ss2 = true;
            s1 = true;
            s2 = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (!s2) s2 = true;
            if (ss1)
            {
              
                    timer1 += 1.84f * Time.deltaTime;
            }
            if (transform.eulerAngles.z < 50)
            {
                timer2 = 0;
                
                    transform.Rotate(new Vector3(0, 0, 0.8f + timer1));
                ss1 = true;
            }
            else
            {
                ss1 = false;
            }
            if (s1) transform.position = transform.position + new Vector3(-1, 0, 0) * 32 * Time.deltaTime;

            if (transform.position.x <= -72f)
                s1 = false;
            else s1 = true;
  

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!s1) s1 = true;

            if (ss2) timer2 += 1.84f * Time.deltaTime;
            if (transform.eulerAngles.z >= 300 || transform.eulerAngles.z == 0)
            {
                timer1 = 0;
                transform.Rotate(new Vector3(0, 0, -0.8f - timer2));
                ss2 = true;
            }
            if (s2) transform.position = transform.position + new Vector3(1, 0, 0) * 32 * Time.deltaTime;
            if (transform.position.x >= 58f)
                s2 = false;
            else s2 = true;
        }
        else
        {
            
            timer1 = 0;
            timer2 = 0;
            ss1 = true;
            ss2 = true;
            s1 = true;
            s2 = true;
        }
        if (meteor)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Instantiate(Meteor, MeteorSpawn.transform.position, MeteorSpawn.transform.rotation);
                meteor = false;
                t2.text = "";
            }
        }
        if (s1 && s2)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, startPos, 150 * Time.deltaTime);
            
        }
    }

    void UpdateKills()
    {
        cc++;
        tt.text = "KILLS: " + cc;

        if (cc == mKills)
        {
            mKills *= 2;
            meteor = true;
            t2.text = "POWERUP";
        }
    }
}

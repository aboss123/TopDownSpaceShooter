using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileBehavior : MonoBehaviour
{

    public GameObject ship;
    public GameObject missile;

    public GameObject spawn1;
    public GameObject spawn2;

    public GameObject particles;

    bool space = false;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) space = true;
    }



    private void FixedUpdate()
    {
        
        if (space)
        {
            System.Random random = new System.Random();
            var a = random.Next(0, 2);

            GameObject v = null;
            if (a == 1)
            {
                 v = Instantiate(missile, spawn1.transform.position, spawn1.transform.rotation, ship.transform);
                GameObject c = Instantiate(particles, spawn1.transform.position, spawn1.transform.rotation);
                c.SendMessage("Pos", v, SendMessageOptions.DontRequireReceiver);
                v.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 50), ForceMode.Impulse);
                

            }
            else
            {
                v = Instantiate(missile, spawn2.transform.position, spawn2.transform.rotation, ship.transform);
                GameObject c = Instantiate(particles, spawn2.transform.position, spawn2.transform.rotation);
                c.SendMessage("Pos", v, SendMessageOptions.DontRequireReceiver);
                v.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 50), ForceMode.Impulse);
                
            }
            space = false;
            v.transform.parent = null;
        }
    }
}

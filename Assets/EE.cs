using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EE : MonoBehaviour
{

    Vector3 moveTowards;
    Vector3[] poses;
    int count = 0;
    bool reached = false;
    int c = 0;
    public GameObject DeathExplosion;
    private GameObject Ship;
    void Start()
    {
        Ship = GameObject.Find("StarSparrow1");
        InvokeRepeating("Destroy", 14, 20);
    }


    void InitTargets(Vector3[] positions)
    {
        poses = positions;
        moveTowards = poses[count++];
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Missile")
        {
            foreach (Transform child in collision.gameObject.transform)
            {
                child.parent = null;
            }
            Destroy(collision.gameObject);
        }

        Ship.SendMessage("UpdateKills", null, SendMessageOptions.DontRequireReceiver);
        Instantiate(DeathExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
       
    }

    void Destroy()
    {
        if (gameObject != null)
            Destroy(gameObject);
    }

    void Update()
    {
        if (!reached) transform.position = Vector3.MoveTowards(transform.position, moveTowards, Time.deltaTime * 40);
        if (transform.position == moveTowards)
        {
            try
            {
                if (count == poses.Length)
                    reached = true;
                moveTowards = poses[count++];
            } catch(System.Exception e)
            {

            }
        }
        if (reached)
        {
            transform.Translate(new Vector3(0, 0, -1) * 20 * Time.deltaTime);
        }
    }
}

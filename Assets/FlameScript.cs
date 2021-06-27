using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameScript : MonoBehaviour
{

    private GameObject follow;
    void Start()
    {
        InvokeRepeating("DestroyObj", 3.2f, 5);
    }


    void Update()
    {

        if (follow != null)
        {
            transform.position = follow.transform.position;
        }
            
    }

    void DestroyObj()
    {
        if (follow != null)
            Destroy(follow);
        Destroy(gameObject);

    }

    void Pos(GameObject obj)
    {
        follow = obj;
    }
}

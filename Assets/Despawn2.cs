using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn2 : MonoBehaviour
{

    void Start()
    {
        InvokeRepeating("DestroyMissile", 5, 5);
    }


    void Update()
    {
        
    }

    void DestroyMissile()
    {
        Destroy(gameObject);
    }
}

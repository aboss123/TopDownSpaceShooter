using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{

    void Start()
    {
        InvokeRepeating("Destroy", 2, 3);
    }

    void Update()
    {
        
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
